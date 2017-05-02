namespace GroupProject
{
    partial class OptionPreview
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
            this.lstHardware = new System.Windows.Forms.ListBox();
            this.lstSoftware = new System.Windows.Forms.ListBox();
            this.lblSoftware = new System.Windows.Forms.Label();
            this.lblHardware = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstHardware
            // 
            this.lstHardware.FormattingEnabled = true;
            this.lstHardware.Location = new System.Drawing.Point(188, 30);
            this.lstHardware.Margin = new System.Windows.Forms.Padding(2);
            this.lstHardware.Name = "lstHardware";
            this.lstHardware.Size = new System.Drawing.Size(173, 251);
            this.lstHardware.TabIndex = 8;
            // 
            // lstSoftware
            // 
            this.lstSoftware.FormattingEnabled = true;
            this.lstSoftware.Location = new System.Drawing.Point(11, 31);
            this.lstSoftware.Margin = new System.Windows.Forms.Padding(2);
            this.lstSoftware.Name = "lstSoftware";
            this.lstSoftware.Size = new System.Drawing.Size(173, 251);
            this.lstSoftware.TabIndex = 7;
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftware.Location = new System.Drawing.Point(11, 9);
            this.lblSoftware.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(73, 20);
            this.lblSoftware.TabIndex = 10;
            this.lblSoftware.Text = "Software";
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardware.Location = new System.Drawing.Point(187, 9);
            this.lblHardware.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(78, 20);
            this.lblHardware.TabIndex = 9;
            this.lblHardware.Text = "Hardware";
            // 
            // OptionPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 293);
            this.Controls.Add(this.lblSoftware);
            this.Controls.Add(this.lblHardware);
            this.Controls.Add(this.lstHardware);
            this.Controls.Add(this.lstSoftware);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OptionPreview";
            this.Text = "View Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHardware;
        private System.Windows.Forms.ListBox lstSoftware;
        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.Label lblHardware;
    }
}