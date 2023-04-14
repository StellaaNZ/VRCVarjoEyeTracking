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

        MainForm()
        {
            InitializeComponent();

            txt_Logger.ReadOnly = true;
            UpdateOutputEnabled();
        }

        public void UpdateValues(Vector leftEye, Vector rightEye, float closeness)
        {
            lbl_LeftEye.Text = $"({leftEye.x.ToString("###.##")}, {leftEye.y.ToString("###.##")}";
            lbl_RightEye.Text = $"({rightEye.x.ToString("###.##")}, {rightEye.y.ToString("###.##")}";
            lbl_Closeness.Text = closeness.ToString("#.###");
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
                lbl_Closeness.Text = "DISABLED";
            }

        }

        private void chk_OutputEnabled_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutputEnabled();
        }

        private void num_LeftMultiplier_ValueChanged(object sender, EventArgs e)
        {
            LeftEyeMultipler = Convert.ToSingle(num_LeftMultiplier.Value);
            if (chk_SyncMultipliers.Checked)
            {
                RightEyeMultipler = LeftEyeMultipler;
                num_RightMultiplier.Value = num_LeftMultiplier.Value;
            }
        }

        private void num_RightMultiplier_ValueChanged(object sender, EventArgs e)
        {
            RightEyeMultipler = Convert.ToSingle(num_RightMultiplier.Value);
            if (chk_SyncMultipliers.Checked)
            {
                LeftEyeMultipler = RightEyeMultipler;
                num_LeftMultiplier.Value = num_RightMultiplier.Value;
            }
        }
    }
}