using System.Numerics;

namespace VRCVarjoEyeTracking
{
    public sealed partial class MainForm : Form
    {
        private static MainForm _instance = null;
        private static readonly object _instanceLock = new object();
        public static MainForm Instance { get { lock (_instanceLock) { if (_instance == null) { _instance = new MainForm(); } return _instance; } } }

        public static bool OutputEnabled = false;
        public static float LeftEyeMultipler = 1.0f;
        public static float RightEyeMultipler = 1.0f;

        public static bool ThresholdEnabled = true;
        public static float OpenThreshold = 0.2f;

        //public static Vector3 LeftEye = new Vector3();
        //public static Vector3 RightEye = new Vector3();

        MainForm()
        {
            InitializeComponent();

            txt_Logger.ReadOnly = true;
            UpdateOutputEnabled();
        }

        public void UpdateValues(DisplayData Data)
        {
            lbl_LeftEye.Text = $"({Data.LeftEye.X.ToString("###.##")}, {Data.LeftEye.Y.ToString("###.##")}, {Data.LeftEye.Z.ToString("###.##")})";
            lbl_RightEye.Text = $"({Data.RightEye.X.ToString("###.##")}, {Data.RightEye.Y.ToString("###.##")}, {Data.RightEye.Z.ToString("###.##")})";
            lbl_LeftOpenness.Text = Data.LeftOpenness.ToString("#.###");
            lbl_RightOpenness.Text = Data.RightOpenness.ToString("#.###");
            lbl_Closeness.Text = Data.AvgCloseness.ToString("#.###");
            lbl_OscCloseness.Text = Data.OscClosenss.ToString("#.###");
        }

        public void AddLoggerMessage(string message)
        {
            try
            {
                if (InvokeRequired)
                {
                    txt_Logger.Invoke(new Action<string>(AddLoggerMessage), new object[] { message });
                    return;
                }

                txt_Logger.AppendText(Environment.NewLine + message);
            }
            catch (ObjectDisposedException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_VRCVarjoEyeTracking_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateOutputEnabled(bool? enabled = null)
        {
            if (enabled == null)
            {
                enabled = chk_OutputEnabled.Checked;
            }
            else
            {
                chk_OutputEnabled.Checked = enabled.Value;
            }

            OutputEnabled = enabled.Value;
            if (!OutputEnabled)
            {
                lbl_LeftEye.Text = "DISABLED";
                lbl_RightEye.Text = "DISABLED";
                lbl_LeftOpenness.Text = "DISABLED";
                lbl_RightOpenness.Text = "DISABLED";
                lbl_Closeness.Text = "DISABLED";
                lbl_OscCloseness.Text = "DISABLED";
            }

        }

        private void chk_OutputEnabled_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutputEnabled();
        }

        private void num_OpenThreshold_ValueChanged(object sender, EventArgs e)
        {
            OpenThreshold = Convert.ToSingle(num_OpenThreshold.Value);
        }

        private void chk_EnableThreshold_CheckedChanged(object sender, EventArgs e)
        {
            ThresholdEnabled = chk_EnableThreshold.Checked;
        }

        private void Eyes_ValueChanged(object sender, EventArgs e)
        {
            //LeftEye.X = Convert.ToSingle(lx.Value);
            //LeftEye.Y = Convert.ToSingle(ly.Value);
            //LeftEye.Z = Convert.ToSingle(lz.Value);

            //RightEye.X = Convert.ToSingle(rx.Value);
            //RightEye.Y = Convert.ToSingle(ry.Value);
            //RightEye.Z = Convert.ToSingle(rz.Value);
        }
    }
}