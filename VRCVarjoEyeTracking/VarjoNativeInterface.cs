using System.Runtime.InteropServices;

namespace VRCVarjoEyeTracking
{
    class VarjoNativeInterface : VarjoInterface
    {
        private IntPtr _session;
        private static MainForm MainForm = MainForm.Instance;

        public override bool Initialize()
        {
            if (!VarjoAvailable())
            {
                MainForm.AddLoggerMessage("Varjo headset isn't detected");
                return false;
            }
            LoadLibrary();
            _session = varjo_SessionInit();
            if (_session == IntPtr.Zero)
            {
                return false;
            }
            if (!varjo_IsGazeAllowed(_session))
            {
                MainForm.AddLoggerMessage("Gaze tracking is not allowed! Please enable it in the Varjo Base!");
                return false;
            }
            varjo_GazeInit(_session);
            varjo_SyncProperties(_session);
            return true;
        }

        public override void Teardown()
        {
            //no need to tear down anything right?
        }

        public override void Update()
        {
            if (_session == IntPtr.Zero)
                return;

            // Get's GazeData and EyeMeasurements from the Varjo SDK
            // Return value states whether or not the request was successful (true = has Data; false = Error occured)
            bool hasData = varjo_GetGazeData(_session, out gazeData, out eyeMeasurements);

            if (!hasData)
                MainForm.AddLoggerMessage("Error while getting Gaze Data");
        }
        public override string GetName()
        {
            return "native DLL";
        }

        private bool LoadLibrary()
        {
            MainForm.AddLoggerMessage("Attempting to load library");
            try
            {
                var path = Path.Combine(Environment.CurrentDirectory, "VarjoLib.dll");
                if (path == null)
                {
                    MainForm.AddLoggerMessage(string.Concat("Couldn't extract the library ", path));
                    return false;
                }
                if (LoadLibrary(path) == IntPtr.Zero) //Where the library gets loaded
                {
                    MainForm.AddLoggerMessage(string.Concat("Unable to load library ", path));
                    return false;
                }
                MainForm.AddLoggerMessage(string.Concat("Loaded library ", path));
                return true;
            }
            catch (Exception ex)
            {
                MainForm.AddLoggerMessage(ex.Message);
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        // I can't ask nicely to add my DLL into the dependency list so I had to steal code from the main repo :(
        //private static IEnumerable<string> ExtractAssemblies(IEnumerable<string> resourceNames)
        //{
        //    var extractedPaths = new List<string>();

        //    var dirName = Path.Combine(Environment.CurrentDirectory, "Libs");
        //    if (!Directory.Exists(dirName))
        //        Directory.CreateDirectory(dirName);

        //    foreach (var dll in resourceNames)
        //    {
        //        var dllPath = Path.Combine(dirName, GetAssemblyNameFromPath(dll));
        //        MainForm.AddLoggerMessage(dllPath);
        //        using (var stm = Assembly.GetAssembly(typeof(VarjoNativeInterface)).GetManifestResourceStream("VRCVarjoEyeTracking.Libs." + dll))
        //        {
        //            if (stm != null)
        //            {
        //                try
        //                {
        //                    using (Stream outFile = File.Create(dllPath))
        //                    {
        //                        const int sz = 4096;
        //                        var buf = new byte[sz];
        //                        while (true)
        //                        {
        //                            if (stm == null) continue;
        //                            var nRead = stm.Read(buf, 0, sz);
        //                            if (nRead < 1)
        //                                break;
        //                            outFile.Write(buf, 0, nRead);
        //                        }
        //                    }

        //                    extractedPaths.Add(dllPath);
        //                }
        //                catch (Exception e)
        //                {
        //                    MessageBox.Show($"Failed to get DLL: " + e.Message);
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Stm was null");
        //            }
        //        }
        //    }
        //    return extractedPaths;
        //}

        //private static string GetAssemblyNameFromPath(string path)
        //{
        //    var splitPath = path.Split('.').ToList();
        //    splitPath.Reverse();
        //    return splitPath[1] + ".dll";
        //}

        [DllImport("kernel32", CharSet = CharSet.Unicode, ExactSpelling = false, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern bool varjo_IsAvailable();

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern IntPtr varjo_SessionInit();

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern void varjo_SessionShutDown(IntPtr session);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern void varjo_GazeInit(IntPtr session);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern int varjo_GetError(IntPtr session);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern string varjo_GetErrorDesc(int errorCode);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern bool varjo_IsGazeAllowed(IntPtr session);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern bool varjo_IsGazeCalibrated(IntPtr session);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern GazeData varjo_GetGaze(IntPtr session);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern bool varjo_GetGazeData(IntPtr session, out GazeData gaze, out EyeMeasurements eyeMeasurements);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern void varjo_RequestGazeCalibration(IntPtr session);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern bool varjo_GetPropertyBool(IntPtr session, int propertyKey);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern int varjo_GetPropertyInt(IntPtr session, int propertyKey);

        [DllImport("VarjoLib", CharSet = CharSet.Auto)]
        private static extern void varjo_SyncProperties(IntPtr session);

    }
}
