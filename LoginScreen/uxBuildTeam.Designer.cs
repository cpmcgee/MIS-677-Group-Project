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
            this.uxGridRequests = new System.Windows.Forms.DataGridView();
            this.lblRequests = new System.Windows.Forms.Label();
            this.lstSoftware = new System.Windows.Forms.ListBox();
            this.lstHardware = new System.Windows.Forms.ListBox();
            this.lblHardware = new System.Windows.Forms.Label();
            this.lblSoftware = new System.Windows.Forms.Label();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // uxGridRequests
            // 
            this.uxGridRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridRequests.Location = new System.Drawing.Point(12, 41);
            this.uxGridRequests.Name = "uxGridRequests";
            this.uxGridRequests.RowTemplate.Height = 24;
            this.uxGridRequests.Size = new System.Drawing.Size(372, 306);
            this.uxGridRequests.TabIndex = 0;
            // 
            // lblRequests
            // 
            this.lblRequests.AutoSize = true;
            this.lblRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequests.Location = new System.Drawing.Point(13, 13);
            this.lblRequests.Name = "lblRequests";
            this.lblRequests.Size = new System.Drawing.Size(163, 25);
            this.lblRequests.TabIndex = 1;
            this.lblRequests.Text = "Requests to Build";
            // 
            // lstSoftware
            // 
            this.lstSoftware.FormattingEnabled = true;
            this.lstSoftware.ItemHeight = 16;
            this.lstSoftware.Location = new System.Drawing.Point(390, 41);
            this.lstSoftware.Name = "lstSoftware";
            this.lstSoftware.Size = new System.Drawing.Size(229, 308);
            this.lstSoftware.TabIndex = 2;
            // 
            // lstHardware
            // 
            this.lstHardware.FormattingEnabled = true;
            this.lstHardware.ItemHeight = 16;
            this.lstHardware.Location = new System.Drawing.Point(625, 41);
            this.lstHardware.Name = "lstHardware";
            this.lstHardware.Size = new System.Drawing.Size(229, 308);
            this.lstHardware.TabIndex = 3;
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardware.Location = new System.Drawing.Point(620, 13);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(96, 25);
            this.lblHardware.TabIndex = 4;
            this.lblHardware.Text = "Hardware";
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftware.Location = new System.Drawing.Point(385, 13);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(89, 25);
            this.lblSoftware.TabIndex = 5;
            this.lblSoftware.Text = "Software";
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.Location = new System.Drawing.Point(12, 353);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(842, 34);
            this.btnMarkCompleted.TabIndex = 6;
            this.btnMarkCompleted.Text = "Mark Request as Completed";
            this.btnMarkCompleted.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(781, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 32);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // uxBuildTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 401);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.lblSoftware);
            this.Controls.Add(this.lblHardware);
            this.Controls.Add(this.lstHardware);
            this.Controls.Add(this.lstSoftware);
            this.Controls.Add(this.lblRequests);
            this.Controls.Add(this.uxGridRequests);
            this.Name = "uxBuildTeam";
            this.Text = "Dashboard - Build Team";
            ((System.ComponentModel.ISupportInitialize)(this.uxGridRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxGridRequests;
        private System.Windows.Forms.Label lblRequests;
        private System.Windows.Forms.ListBox lstSoftware;
        private System.Windows.Forms.ListBox lstHardware;
        private System.Windows.Forms.Label lblHardware;
        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.Button btnLogout;
    }
}