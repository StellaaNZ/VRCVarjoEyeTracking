using SharpOSC;

namespace VRCVarjoEyeTracking
{
    internal static class Program
    {
        private const string AVATAR_EYE_TRACKING_ADDRESS = "/tracking/eye/LeftRightPitchYaw";
        private const string AVATAR_EYE_CLOSENESS_ADDRESS = "/tracking/eye/EyesClosedAmount";
        private const string AVATAR_PARAMETERS_PREFIX = "/avatar/parameters/";
        private const string IP_ADDRESS = "127.0.0.1";
        private const int PORT_SEND = 9000;
        private const int SEND_CYCLE_MILLISECONDS = 50;

        private static VarjoInterface tracker = new VarjoNativeInterface();
        private static EventHandler _applicationIdleHandler;
        private static Thread _sendingThread;
        private static UDPSender _sender;

        private static OscMessage _eyeTrackingMessage;
        private static OscMessage _eyeClosenessMessage;


        private static frm_VRCVarjoEyeTracking MainForm;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainForm = frm_VRCVarjoEyeTracking.Instance;

                _applicationIdleHandler = delegate
                {
                    SetupSender();

                    Application.Idle -= _applicationIdleHandler;
                };

                Application.Idle += _applicationIdleHandler;

                //Application.ApplicationExit += delegate
                //{
                //    _sender.Close();
                //    tracker.Teardown();
                //    _sendingThread.Interrupt();
                //    _sendingThread.Join();
                //};

                Application.Run(MainForm);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainForm.AddLoggerMessage(ex.Message);
            }
        }

        private static void SetupSender()
        {
            if (InitializeTracking())
            {
                _sender = new UDPSender(IP_ADDRESS, PORT_SEND);
                _sendingThread = new Thread(new ThreadStart(SendingLoop));
                _sendingThread.Start();

                Application.ApplicationExit += delegate
                {
                    _sender.Close();
                    tracker.Teardown();
                    _sendingThread.Interrupt();
                    _sendingThread.Join();
                };
            }
        }

        private static void SendingLoop()
        {
            try
            {
                MainForm.AddLoggerMessage("Starting Sending Loop");
                while (true)
                {
                    tracker.Update();
                    GazeData eyeData = tracker.GetGazeData();
                    EyeMeasurements eyeMeasurements = tracker.GetEyeMeasurements();
                    Vector leftEye = eyeData.leftEye.forward;
                    Vector rightEye = eyeData.rightEye.forward;


                    List<object> values = new List<object> { -leftEye.y, leftEye.x, -rightEye.y, rightEye.x };
                    float closeness = (eyeMeasurements.leftEyeOpenness + eyeMeasurements.rightEyeOpenness) / 2;

                    if (frm_VRCVarjoEyeTracking.OutputEnabled)
                    {
                        MainForm.AddLoggerMessage($"Left Eye Values: ({leftEye.x},{leftEye.y})");
                        MainForm.AddLoggerMessage($"Right Eye Values: ({rightEye.x},{rightEye.y})");
                        MainForm.AddLoggerMessage($"Closeness Value: {closeness}");
                    }

                    _eyeTrackingMessage = new OscMessage(AVATAR_EYE_TRACKING_ADDRESS, values);
                    _eyeClosenessMessage = new OscMessage(AVATAR_EYE_CLOSENESS_ADDRESS, closeness);

                    List<OscMessage> sendingMessages = new List<OscMessage> { _eyeTrackingMessage, _eyeClosenessMessage };

                    ulong time = (ulong)(DateTime.UtcNow - new DateTime(1900, 1, 1)).TotalMilliseconds * 1000;
                    OscBundle bundle = new OscBundle (time)
                    {
                        Messages = sendingMessages,
                        Timestamp = DateTime.Now,
                    };

                    _sender.Send(bundle);

                    Thread.Sleep(SEND_CYCLE_MILLISECONDS);
                }
            }
            catch (Exception ex)
            {
                MainForm.AddLoggerMessage(ex.Message);
                MainForm.AddLoggerMessage(ex.StackTrace);
            }
            finally 
            { 
                _sender.Close();
                tracker.Teardown();
            }
        }

        private static bool InitializeTracking()
        {
            MainForm.AddLoggerMessage(string.Format("Initializing {0} Varjo module", tracker.GetName()));
            bool pipeConnected = tracker.Initialize();
            return pipeConnected;
        }
    }


}