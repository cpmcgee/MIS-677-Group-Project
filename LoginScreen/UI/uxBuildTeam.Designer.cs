namespace GroupProject
{
    partial class uxBuildTeam
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
            this.lblRequests = new System.Windows.Forms.Label();
            this.lstSoftware = new System.Windows.Forms.ListBox();
            this.lstHardware = new System.Windows.Forms.ListBox();
            this.lblHardware = new System.Windows.Forms.Label();
            this.lblSoftware = new System.Windows.Forms.Label();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstRequests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblRequests
            // 
            this.lblRequests.AutoSize = true;
            this.lblRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequests.Location = new System.Drawing.Point(10, 11);
            this.lblRequests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequests.Name = "lblRequests";
            this.lblRequests.Size = new System.Drawing.Size(135, 20);
            this.lblRequests.TabIndex = 1;
            this.lblRequests.Text = "Requests to Build";
            // 
            // lstSoftware
            // 
            this.lstSoftware.FormattingEnabled = true;
            this.lstSoftware.Location = new System.Drawing.Point(292, 33);
            this.lstSoftware.Margin = new System.Windows.Forms.Padding(2);
            this.lstSoftware.Name = "lstSoftware";
            this.lstSoftware.Size = new System.Drawing.Size(173, 212);
            this.lstSoftware.TabIndex = 2;
            // 
            // lstHardware
            // 
            this.lstHardware.FormattingEnabled = true;
            this.lstHardware.Location = new System.Drawing.Point(469, 33);
            this.lstHardware.Margin = new System.Windows.Forms.Padding(2);
            this.lstHardware.Name = "lstHardware";
            this.lstHardware.Size = new System.Drawing.Size(173, 212);
            this.lstHardware.TabIndex = 3;
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardware.Location = new System.Drawing.Point(465, 11);
            this.lblHardware.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(78, 20);
            this.lblHardware.TabIndex = 4;
            this.lblHardware.Text = "Hardware";
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftware.Location = new System.Drawing.Point(289, 11);
            this.lblSoftware.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(73, 20);
            this.lblSoftware.TabIndex = 5;
            this.lblSoftware.Text = "Software";
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.Location = new System.Drawing.Point(292, 251);
            this.btnMarkCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(349, 28);
            this.btnMarkCompleted.TabIndex = 6;
            this.btnMarkCompleted.Text = "Mark Request as Completed";
            this.btnMarkCompleted.UseVisualStyleBackColor = true;
            this.btnMarkCompleted.Click += new System.EventHandler(this.btnMarkCompleted_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(586, 3);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(56, 26);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstRequests
            // 
            this.lstRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRequests.FormattingEnabled = true;
            this.lstRequests.ItemHeight = 16;
            this.lstRequests.Location = new System.Drawing.Point(14, 35);
            this.lstRequests.Name = "lstRequests";
            this.lstRequests.Size = new System.Drawing.Size(273, 244);
            this.lstRequests.TabIndex = 8;
            this.lstRequests.SelectedIndexChanged += new System.EventHandler(this.lstRequests_SelectedIndexChanged);
            // 
            // uxBuildTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 296);
            this.Controls.Add(this.lstRequests);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.lblSoftware);
            this.Controls.Add(this.lblHardware);
            this.Controls.Add(this.lstHardware);
            this.Controls.Add(this.lstSoftware);
            this.Controls.Add(this.lblRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uxBuildTeam";
            this.Text = "Dashboard - Build Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRequests;
        private System.Windows.Forms.ListBox lstSoftware;
        private System.Windows.Forms.ListBox lstHardware;
        private System.Windows.Forms.Label lblHardware;
        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListBox lstRequests;
    }
}