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
            ((System.ComponentModel.ISupportInitialize)(this.tbCpuUtilization)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCpuUtilization
            // 
            this.tbCpuUtilization.Location = new System.Drawing.Point(12, 51);
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
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU Utilization";
            // 
            // Steve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

