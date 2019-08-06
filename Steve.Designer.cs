namespace Steve
{
    partial class Steve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCpuUtilization = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCpu = new System.Windows.Forms.Label();
            this.cbCorePreference = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tbCpuUtilization)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCpuUtilization
            // 
            this.tbCpuUtilization.Location = new System.Drawing.Point(12, 80);
            this.tbCpuUtilization.Maximum = 100;
            this.tbCpuUtilization.Name = "tbCpuUtilization";
            this.tbCpuUtilization.Size = new System.Drawing.Size(341, 45);
            this.tbCpuUtilization.TabIndex = 0;
            this.tbCpuUtilization.TickFrequency = 5;
            this.tbCpuUtilization.ValueChanged += new System.EventHandler(this.TbCpuUtilization_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU Utilization:";
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(324, 45);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(21, 13);
            this.lblCpu.TabIndex = 2;
            this.lblCpu.Text = "0%";
            // 
            // cbCorePreference
            // 
            this.cbCorePreference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCorePreference.FormattingEnabled = true;
            this.cbCorePreference.Items.AddRange(new object[] {
            "Single-Core",
            "Multi-Core"});
            this.cbCorePreference.Location = new System.Drawing.Point(12, 42);
            this.cbCorePreference.Name = "cbCorePreference";
            this.cbCorePreference.Size = new System.Drawing.Size(121, 21);
            this.cbCorePreference.TabIndex = 3;
            // 
            // Steve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 153);
            this.Controls.Add(this.cbCorePreference);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCpuUtilization);
            this.Name = "Steve";
            this.Text = "Steve";
            ((System.ComponentModel.ISupportInitialize)(this.tbCpuUtilization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbCpuUtilization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.ComboBox cbCorePreference;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

