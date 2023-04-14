namespace VRCVarjoEyeTracking
{
    partial class MainForm
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
            label1 = new Label();
            lbl_LeftEye = new Label();
            label2 = new Label();
            lbl_RightEye = new Label();
            label4 = new Label();
            lbl_Closeness = new Label();
            chk_SyncMultipliers = new CheckBox();
            num_LeftMultiplier = new NumericUpDown();
            num_RightMultiplier = new NumericUpDown();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)num_LeftMultiplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_RightMultiplier).BeginInit();
            SuspendLayout();
            // 
            // txt_Logger
            // 
            txt_Logger.Location = new Point(12, 12);
            txt_Logger.Multiline = true;
            txt_Logger.Name = "txt_Logger";
            txt_Logger.ReadOnly = true;
            txt_Logger.Size = new Size(566, 426);
            txt_Logger.TabIndex = 0;
            // 
            // chk_OutputEnabled
            // 
            chk_OutputEnabled.AutoSize = true;
            chk_OutputEnabled.Checked = true;
            chk_OutputEnabled.CheckState = CheckState.Checked;
            chk_OutputEnabled.Location = new Point(616, 18);
            chk_OutputEnabled.Name = "chk_OutputEnabled";
            chk_OutputEnabled.Size = new Size(109, 19);
            chk_OutputEnabled.TabIndex = 1;
            chk_OutputEnabled.Text = "Output Enabled";
            chk_OutputEnabled.UseVisualStyleBackColor = true;
            chk_OutputEnabled.CheckedChanged += chk_OutputEnabled_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(612, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Left Eye:";
            // 
            // lbl_LeftEye
            // 
            lbl_LeftEye.BorderStyle = BorderStyle.FixedSingle;
            lbl_LeftEye.Location = new Point(680, 39);
            lbl_LeftEye.Name = "lbl_LeftEye";
            lbl_LeftEye.Size = new Size(89, 17);
            lbl_LeftEye.TabIndex = 2;
            lbl_LeftEye.Text = "(100.99, 100.99)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 58);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Right Eye:";
            // 
            // lbl_RightEye
            // 
            lbl_RightEye.BorderStyle = BorderStyle.FixedSingle;
            lbl_RightEye.Location = new Point(680, 57);
            lbl_RightEye.Name = "lbl_RightEye";
            lbl_RightEye.Size = new Size(89, 17);
            lbl_RightEye.TabIndex = 2;
            lbl_RightEye.Text = "(100.99, 100.99)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(612, 76);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 2;
            label4.Text = "Closeness:";
            // 
            // lbl_Closeness
            // 
            lbl_Closeness.BorderStyle = BorderStyle.FixedSingle;
            lbl_Closeness.Location = new Point(680, 75);
            lbl_Closeness.Name = "lbl_Closeness";
            lbl_Closeness.Size = new Size(89, 17);
            lbl_Closeness.TabIndex = 2;
            lbl_Closeness.Text = "0";
            // 
            // chk_SyncMultipliers
            // 
            chk_SyncMultipliers.AutoSize = true;
            chk_SyncMultipliers.Checked = true;
            chk_SyncMultipliers.CheckState = CheckState.Checked;
            chk_SyncMultipliers.Location = new Point(616, 124);
            chk_SyncMultipliers.Name = "chk_SyncMultipliers";
            chk_SyncMultipliers.Size = new Size(110, 19);
            chk_SyncMultipliers.TabIndex = 3;
            chk_SyncMultipliers.Text = "Sync Mulitpliers";
            chk_SyncMultipliers.UseVisualStyleBackColor = true;
            // 
            // num_LeftMultiplier
            // 
            num_LeftMultiplier.DecimalPlaces = 2;
            num_LeftMultiplier.Location = new Point(710, 149);
            num_LeftMultiplier.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            num_LeftMultiplier.Name = "num_LeftMultiplier";
            num_LeftMultiplier.Size = new Size(59, 23);
            num_LeftMultiplier.TabIndex = 4;
            num_LeftMultiplier.Value = new decimal(new int[] { 20, 0, 0, 0 });
            num_LeftMultiplier.ValueChanged += num_LeftMultiplier_ValueChanged;
            // 
            // num_RightMultiplier
            // 
            num_RightMultiplier.DecimalPlaces = 2;
            num_RightMultiplier.Location = new Point(710, 178);
            num_RightMultiplier.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            num_RightMultiplier.Name = "num_RightMultiplier";
            num_RightMultiplier.Size = new Size(59, 23);
            num_RightMultiplier.TabIndex = 4;
            num_RightMultiplier.Value = new decimal(new int[] { 20, 0, 0, 0 });
            num_RightMultiplier.ValueChanged += num_RightMultiplier_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(612, 151);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 5;
            label3.Text = "Left Multiplier:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(612, 180);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 5;
            label5.Text = "Right Multiplier:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(num_RightMultiplier);
            Controls.Add(num_LeftMultiplier);
            Controls.Add(chk_SyncMultipliers);
            Controls.Add(lbl_Closeness);
            Controls.Add(label4);
            Controls.Add(lbl_RightEye);
            Controls.Add(label2);
            Controls.Add(lbl_LeftEye);
            Controls.Add(label1);
            Controls.Add(chk_OutputEnabled);
            Controls.Add(txt_Logger);
            Name = "MainForm";
            Text = "VRCVarjoEyeTracking";
            FormClosing += frm_VRCVarjoEyeTracking_FormClosing;
            ((System.ComponentModel.ISupportInitialize)num_LeftMultiplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_RightMultiplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Logger;
        private CheckBox chk_OutputEnabled;
        private Label label1;
        private Label lbl_LeftEye;
        private Label label2;
        private Label lbl_RightEye;
        private Label label4;
        private Label lbl_Closeness;
        private CheckBox chk_SyncMultipliers;
        private NumericUpDown num_LeftMultiplier;
        private NumericUpDown num_RightMultiplier;
        private Label label3;
        private Label label5;
    }
}