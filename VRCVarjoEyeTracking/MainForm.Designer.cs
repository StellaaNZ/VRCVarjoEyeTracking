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
            num_OpenThreshold = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            lbl_OscCloseness = new Label();
            label8 = new Label();
            lbl_LeftOpenness = new Label();
            label10 = new Label();
            lbl_RightOpenness = new Label();
            chk_EnableThreshold = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)num_OpenThreshold).BeginInit();
            SuspendLayout();
            // 
            // txt_Logger
            // 
            txt_Logger.Location = new Point(12, 12);
            txt_Logger.Multiline = true;
            txt_Logger.Name = "txt_Logger";
            txt_Logger.ReadOnly = true;
            txt_Logger.ScrollBars = ScrollBars.Vertical;
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
            lbl_LeftEye.Size = new Size(116, 17);
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
            lbl_RightEye.Size = new Size(116, 17);
            lbl_RightEye.TabIndex = 2;
            lbl_RightEye.Text = "(100.99, 100.99)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(612, 114);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 2;
            label4.Text = "Avg Closeness:";
            // 
            // lbl_Closeness
            // 
            lbl_Closeness.BorderStyle = BorderStyle.FixedSingle;
            lbl_Closeness.Location = new Point(735, 113);
            lbl_Closeness.Name = "lbl_Closeness";
            lbl_Closeness.Size = new Size(61, 18);
            lbl_Closeness.TabIndex = 2;
            lbl_Closeness.Text = "0";
            // 
            // num_OpenThreshold
            // 
            num_OpenThreshold.DecimalPlaces = 2;
            num_OpenThreshold.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            num_OpenThreshold.Location = new Point(710, 196);
            num_OpenThreshold.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            num_OpenThreshold.Name = "num_OpenThreshold";
            num_OpenThreshold.Size = new Size(70, 23);
            num_OpenThreshold.TabIndex = 4;
            num_OpenThreshold.Value = new decimal(new int[] { 2, 0, 0, 65536 });
            num_OpenThreshold.ValueChanged += num_OpenThreshold_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(612, 198);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 5;
            label6.Text = "Open Threshold:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(612, 133);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 2;
            label7.Text = "Threshold Closeness:";
            // 
            // lbl_OscCloseness
            // 
            lbl_OscCloseness.BorderStyle = BorderStyle.FixedSingle;
            lbl_OscCloseness.Location = new Point(735, 132);
            lbl_OscCloseness.Name = "lbl_OscCloseness";
            lbl_OscCloseness.Size = new Size(61, 16);
            lbl_OscCloseness.TabIndex = 2;
            lbl_OscCloseness.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(612, 76);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 2;
            label8.Text = "Left Openness:";
            // 
            // lbl_LeftOpenness
            // 
            lbl_LeftOpenness.BorderStyle = BorderStyle.FixedSingle;
            lbl_LeftOpenness.Location = new Point(735, 75);
            lbl_LeftOpenness.Name = "lbl_LeftOpenness";
            lbl_LeftOpenness.Size = new Size(61, 18);
            lbl_LeftOpenness.TabIndex = 2;
            lbl_LeftOpenness.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(612, 95);
            label10.Name = "label10";
            label10.Size = new Size(93, 15);
            label10.TabIndex = 2;
            label10.Text = "Right Openness:";
            // 
            // lbl_RightOpenness
            // 
            lbl_RightOpenness.BorderStyle = BorderStyle.FixedSingle;
            lbl_RightOpenness.Location = new Point(735, 94);
            lbl_RightOpenness.Name = "lbl_RightOpenness";
            lbl_RightOpenness.Size = new Size(61, 18);
            lbl_RightOpenness.TabIndex = 2;
            lbl_RightOpenness.Text = "0";
            // 
            // chk_EnableThreshold
            // 
            chk_EnableThreshold.AutoSize = true;
            chk_EnableThreshold.Checked = true;
            chk_EnableThreshold.CheckState = CheckState.Checked;
            chk_EnableThreshold.Location = new Point(616, 176);
            chk_EnableThreshold.Name = "chk_EnableThreshold";
            chk_EnableThreshold.Size = new Size(116, 19);
            chk_EnableThreshold.TabIndex = 7;
            chk_EnableThreshold.Text = "Enable Threshold";
            chk_EnableThreshold.UseVisualStyleBackColor = true;
            chk_EnableThreshold.CheckedChanged += chk_EnableThreshold_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(chk_EnableThreshold);
            Controls.Add(label6);
            Controls.Add(num_OpenThreshold);
            Controls.Add(lbl_OscCloseness);
            Controls.Add(lbl_RightOpenness);
            Controls.Add(lbl_LeftOpenness);
            Controls.Add(lbl_Closeness);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label8);
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
            ((System.ComponentModel.ISupportInitialize)num_OpenThreshold).EndInit();
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
        private NumericUpDown num_OpenThreshold;
        private Label label6;
        private Label label7;
        private Label lbl_OscCloseness;
        private Label label8;
        private Label lbl_LeftOpenness;
        private Label label10;
        private Label lbl_RightOpenness;
        private CheckBox chk_EnableThreshold;
    }
}