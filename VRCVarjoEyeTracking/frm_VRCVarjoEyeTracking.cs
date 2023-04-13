namespace VRCVarjoEyeTracking
{
    public partial class frm_VRCVarjoEyeTracking : Form
    {
        private static frm_VRCVarjoEyeTracking _instance = new frm_VRCVarjoEyeTracking();
        public static frm_VRCVarjoEyeTracking Instance => _instance;

        public static bool OutputEnabled = false;
        public frm_VRCVarjoEyeTracking()
        {
            InitializeComponent();

            txt_Logger.ReadOnly = true;
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

        private void chk_OutputEnabled_CheckedChanged(object sender, EventArgs e)
        {
            OutputEnabled = chk_OutputEnabled.Checked;
        }
    }
}