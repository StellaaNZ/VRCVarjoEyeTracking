namespace VRCVarjoEyeTracking
{
    partial class frm_VRCVarjoEyeTracking
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Logger = new TextBox();
            chk_OutputEnabled = new CheckBox();
            SuspendLayout();
            // 
            // txt_Logger
            // 
            txt_Logger.Location = new Point(12, 39);
            txt_Logger.Multiline = true;
            txt_Logger.Name = "txt_Logger";
            txt_Logger.ReadOnly = true;
            txt_Logger.Size = new Size(776, 399);
            txt_Logger.TabIndex = 0;
            // 
            // chk_OutputEnabled
            // 
            chk_OutputEnabled.AutoSize = true;
            chk_OutputEnabled.Location = new Point(12, 12);
            chk_OutputEnabled.Name = "chk_OutputEnabled";
            chk_OutputEnabled.Size = new Size(109, 19);
            chk_OutputEnabled.TabIndex = 1;
            chk_OutputEnabled.Text = "Output Enabled";
            chk_OutputEnabled.UseVisualStyleBackColor = true;
            chk_OutputEnabled.CheckedChanged += chk_OutputEnabled_CheckedChanged;
            // 
            // frm_VRCVarjoEyeTracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chk_OutputEnabled);
            Controls.Add(txt_Logger);
            Name = "frm_VRCVarjoEyeTracking";
            Text = "VRCVarjoEyeTracking";
            FormClosing += frm_VRCVarjoEyeTracking_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Logger;
        private CheckBox chk_OutputEnabled;
    }
}