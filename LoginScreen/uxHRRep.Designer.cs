namespace GroupProject
{
    partial class uxHRRep
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
            this.lstUnnasigned = new System.Windows.Forms.ListBox();
            this.lblUnassigned = new System.Windows.Forms.Label();
            this.lstSupervisors = new System.Windows.Forms.ListBox();
            this.lblSupervisors = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.uxGridViewRequests = new System.Windows.Forms.DataGridView();
            this.btnSendToManager = new System.Windows.Forms.Button();
            this.uxGridViewCompleted = new System.Windows.Forms.DataGridView();
            this.lblComplete = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDelay = new System.Windows.Forms.Button();
            this.btnSendToBuildTeam = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridViewRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridViewCompleted)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUnnasigned
            // 
            this.lstUnnasigned.FormattingEnabled = true;
            this.lstUnnasigned.ItemHeight = 16;
            this.lstUnnasigned.Location = new System.Drawing.Point(12, 39);
            this.lstUnnasigned.Name = "lstUnnasigned";
            this.lstUnnasigned.Size = new System.Drawing.Size(209, 164);
            this.lstUnnasigned.TabIndex = 0;
            // 
            // lblUnassigned
            // 
            this.lblUnassigned.AutoSize = true;
            this.lblUnassigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnassigned.Location = new System.Drawing.Point(13, 11);
            this.lblUnassigned.Name = "lblUnassigned";
            this.lblUnassigned.Size = new System.Drawing.Size(176, 25);
            this.lblUnassigned.TabIndex = 1;
            this.lblUnassigned.Text = "Un-Assigned Hires";
            // 
            // lstSupervisors
            // 
            this.lstSupervisors.FormattingEnabled = true;
            this.lstSupervisors.ItemHeight = 16;
            this.lstSupervisors.Location = new System.Drawing.Point(228, 39);
            this.lstSupervisors.Name = "lstSupervisors";
            this.lstSupervisors.Size = new System.Drawing.Size(207, 164);
            this.lstSupervisors.TabIndex = 2;
            // 
            // lblSupervisors
            // 
            this.lblSupervisors.AutoSize = true;
            this.lblSupervisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisors.Location = new System.Drawing.Point(223, 11);
            this.lblSupervisors.Name = "lblSupervisors";
            this.lblSupervisors.Size = new System.Drawing.Size(201, 25);
            this.lblSupervisors.TabIndex = 3;
            this.lblSupervisors.Text = "Available Supervisors";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(12, 209);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(423, 37);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign Hire to Supervisor";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // uxGridViewRequests
            // 
            this.uxGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridViewRequests.Location = new System.Drawing.Point(12, 290);
            this.uxGridViewRequests.Name = "uxGridViewRequests";
            this.uxGridViewRequests.RowTemplate.Height = 24;
            this.uxGridViewRequests.Size = new System.Drawing.Size(869, 178);
            this.uxGridViewRequests.TabIndex = 5;
            // 
            // btnSendToManager
            // 
            this.btnSendToManager.Location = new System.Drawing.Point(10, 474);
            this.btnSendToManager.Name = "btnSendToManager";
            this.btnSendToManager.Size = new System.Drawing.Size(211, 37);
            this.btnSendToManager.TabIndex = 6;
            this.btnSendToManager.Text = "Send to Manager for Approval";
            this.btnSendToManager.UseVisualStyleBackColor = true;
            // 
            // uxGridViewCompleted
            // 
            this.uxGridViewCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridViewCompleted.Location = new System.Drawing.Point(458, 39);
            this.uxGridViewCompleted.Name = "uxGridViewCompleted";
            this.uxGridViewCompleted.RowTemplate.Height = 24;
            this.uxGridViewCompleted.Size = new System.Drawing.Size(423, 164);
            this.uxGridViewCompleted.TabIndex = 7;
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.Location = new System.Drawing.Point(453, 11);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(194, 25);
            this.lblComplete.TabIndex = 9;
            this.lblComplete.Text = "Completed Requests";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.Location = new System.Drawing.Point(12, 262);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(171, 25);
            this.lblPending.TabIndex = 10;
            this.lblPending.Text = "Pending Requests";
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(458, 209);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(141, 37);
            this.btnApprove.TabIndex = 11;
            this.btnApprove.Text = "Approve Request";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnDelay
            // 
            this.btnDelay.Location = new System.Drawing.Point(740, 209);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(141, 37);
            this.btnDelay.TabIndex = 12;
            this.btnDelay.Text = "Delay Request";
            this.btnDelay.UseVisualStyleBackColor = true;
            // 
            // btnSendToBuildTeam
            // 
            this.btnSendToBuildTeam.Location = new System.Drawing.Point(670, 474);
            this.btnSendToBuildTeam.Name = "btnSendToBuildTeam";
            this.btnSendToBuildTeam.Size = new System.Drawing.Size(211, 37);
            this.btnSendToBuildTeam.TabIndex = 13;
            this.btnSendToBuildTeam.Text = "Send to Build Team";
            this.btnSendToBuildTeam.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(806, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 33);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // uxHRRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 524);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSendToBuildTeam);
            this.Controls.Add(this.btnDelay);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.uxGridViewCompleted);
            this.Controls.Add(this.btnSendToManager);
            this.Controls.Add(this.uxGridViewRequests);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lblSupervisors);
            this.Controls.Add(this.lstSupervisors);
            this.Controls.Add(this.lblUnassigned);
            this.Controls.Add(this.lstUnnasigned);
            this.Name = "uxHRRep";
            this.Text = "Dashboard - HR";
            ((System.ComponentModel.ISupportInitialize)(this.uxGridViewRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridViewCompleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUnnasigned;
        private System.Windows.Forms.Label lblUnassigned;
        private System.Windows.Forms.ListBox lstSupervisors;
        private System.Windows.Forms.Label lblSupervisors;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView uxGridViewRequests;
        private System.Windows.Forms.Button btnSendToManager;
        private System.Windows.Forms.DataGridView uxGridViewCompleted;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDelay;
        private System.Windows.Forms.Button btnSendToBuildTeam;
        private System.Windows.Forms.Button btnLogout;
    }
}