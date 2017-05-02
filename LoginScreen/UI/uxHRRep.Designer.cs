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
            this.colReqNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendToManager = new System.Windows.Forms.Button();
            this.uxGridViewCompleted = new System.Windows.Forms.DataGridView();
            this.colCompNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComplete = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDelay = new System.Windows.Forms.Button();
            this.btnSendToBuildTeam = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPreview2 = new System.Windows.Forms.Button();
            this.btnPreview1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridViewRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridViewCompleted)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUnnasigned
            // 
            this.lstUnnasigned.FormattingEnabled = true;
            this.lstUnnasigned.Location = new System.Drawing.Point(9, 32);
            this.lstUnnasigned.Margin = new System.Windows.Forms.Padding(2);
            this.lstUnnasigned.Name = "lstUnnasigned";
            this.lstUnnasigned.Size = new System.Drawing.Size(143, 134);
            this.lstUnnasigned.TabIndex = 0;
            // 
            // lblUnassigned
            // 
            this.lblUnassigned.AutoSize = true;
            this.lblUnassigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnassigned.Location = new System.Drawing.Point(4, 10);
            this.lblUnassigned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnassigned.Name = "lblUnassigned";
            this.lblUnassigned.Size = new System.Drawing.Size(142, 20);
            this.lblUnassigned.TabIndex = 1;
            this.lblUnassigned.Text = "Un-Assigned Hires";
            // 
            // lstSupervisors
            // 
            this.lstSupervisors.FormattingEnabled = true;
            this.lstSupervisors.Location = new System.Drawing.Point(156, 33);
            this.lstSupervisors.Margin = new System.Windows.Forms.Padding(2);
            this.lstSupervisors.Name = "lstSupervisors";
            this.lstSupervisors.Size = new System.Drawing.Size(144, 134);
            this.lstSupervisors.TabIndex = 2;
            // 
            // lblSupervisors
            // 
            this.lblSupervisors.AutoSize = true;
            this.lblSupervisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisors.Location = new System.Drawing.Point(152, 9);
            this.lblSupervisors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupervisors.Name = "lblSupervisors";
            this.lblSupervisors.Size = new System.Drawing.Size(133, 20);
            this.lblSupervisors.TabIndex = 3;
            this.lblSupervisors.Text = "Avail. Supervisors";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(9, 170);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(291, 30);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign Hire to Supervisor";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // uxGridViewRequests
            // 
            this.uxGridViewRequests.AllowUserToAddRows = false;
            this.uxGridViewRequests.AllowUserToDeleteRows = false;
            this.uxGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridViewRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReqNum,
            this.colFirst,
            this.colLast,
            this.colDate,
            this.colRequestedBy,
            this.colStatus});
            this.uxGridViewRequests.Location = new System.Drawing.Point(9, 236);
            this.uxGridViewRequests.Margin = new System.Windows.Forms.Padding(2);
            this.uxGridViewRequests.MultiSelect = false;
            this.uxGridViewRequests.Name = "uxGridViewRequests";
            this.uxGridViewRequests.RowTemplate.Height = 24;
            this.uxGridViewRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxGridViewRequests.Size = new System.Drawing.Size(650, 145);
            this.uxGridViewRequests.TabIndex = 5;
            // 
            // colReqNum
            // 
            this.colReqNum.HeaderText = "Request #";
            this.colReqNum.Name = "colReqNum";
            // 
            // colFirst
            // 
            this.colFirst.HeaderText = "First Name";
            this.colFirst.Name = "colFirst";
            // 
            // colLast
            // 
            this.colLast.HeaderText = "Last Name";
            this.colLast.Name = "colLast";
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Requested Date";
            this.colDate.Name = "colDate";
            // 
            // colRequestedBy
            // 
            this.colRequestedBy.HeaderText = "Requested By";
            this.colRequestedBy.Name = "colRequestedBy";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // btnSendToManager
            // 
            this.btnSendToManager.Location = new System.Drawing.Point(8, 385);
            this.btnSendToManager.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendToManager.Name = "btnSendToManager";
            this.btnSendToManager.Size = new System.Drawing.Size(158, 30);
            this.btnSendToManager.TabIndex = 6;
            this.btnSendToManager.Text = "Send to Manager for Approval";
            this.btnSendToManager.UseVisualStyleBackColor = true;
            this.btnSendToManager.Click += new System.EventHandler(this.btnSendToManager_Click);
            // 
            // uxGridViewCompleted
            // 
            this.uxGridViewCompleted.AllowUserToAddRows = false;
            this.uxGridViewCompleted.AllowUserToDeleteRows = false;
            this.uxGridViewCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridViewCompleted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompNum,
            this.colCompName,
            this.colCompDate});
            this.uxGridViewCompleted.Location = new System.Drawing.Point(319, 33);
            this.uxGridViewCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.uxGridViewCompleted.MultiSelect = false;
            this.uxGridViewCompleted.Name = "uxGridViewCompleted";
            this.uxGridViewCompleted.RowTemplate.Height = 24;
            this.uxGridViewCompleted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxGridViewCompleted.Size = new System.Drawing.Size(342, 133);
            this.uxGridViewCompleted.TabIndex = 7;
            // 
            // colCompNum
            // 
            this.colCompNum.HeaderText = "Request #";
            this.colCompNum.Name = "colCompNum";
            // 
            // colCompName
            // 
            this.colCompName.HeaderText = "Last Name";
            this.colCompName.Name = "colCompName";
            // 
            // colCompDate
            // 
            this.colCompDate.HeaderText = "Completed Date";
            this.colCompDate.Name = "colCompDate";
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.Location = new System.Drawing.Point(315, 10);
            this.lblComplete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(133, 20);
            this.lblComplete.TabIndex = 9;
            this.lblComplete.Text = "Completed Builds";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.Location = new System.Drawing.Point(9, 213);
            this.lblPending.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(140, 20);
            this.lblPending.TabIndex = 10;
            this.lblPending.Text = "Pending Requests";
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(319, 170);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(106, 30);
            this.btnApprove.TabIndex = 11;
            this.btnApprove.Text = "Approve Build";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDelay
            // 
            this.btnDelay.Location = new System.Drawing.Point(555, 170);
            this.btnDelay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(106, 30);
            this.btnDelay.TabIndex = 12;
            this.btnDelay.Text = "Delay Request";
            this.btnDelay.UseVisualStyleBackColor = true;
            this.btnDelay.Click += new System.EventHandler(this.btnDelay_Click);
            // 
            // btnSendToBuildTeam
            // 
            this.btnSendToBuildTeam.Location = new System.Drawing.Point(502, 385);
            this.btnSendToBuildTeam.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendToBuildTeam.Name = "btnSendToBuildTeam";
            this.btnSendToBuildTeam.Size = new System.Drawing.Size(158, 30);
            this.btnSendToBuildTeam.TabIndex = 13;
            this.btnSendToBuildTeam.Text = "Send to Build Team";
            this.btnSendToBuildTeam.UseVisualStyleBackColor = true;
            this.btnSendToBuildTeam.Click += new System.EventHandler(this.btnSendToBuildTeam_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(604, 2);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(56, 27);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPreview2
            // 
            this.btnPreview2.Location = new System.Drawing.Point(274, 385);
            this.btnPreview2.Name = "btnPreview2";
            this.btnPreview2.Size = new System.Drawing.Size(101, 30);
            this.btnPreview2.TabIndex = 15;
            this.btnPreview2.Text = "View Request";
            this.btnPreview2.UseVisualStyleBackColor = true;
            this.btnPreview2.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPreview1
            // 
            this.btnPreview1.Location = new System.Drawing.Point(440, 171);
            this.btnPreview1.Name = "btnPreview1";
            this.btnPreview1.Size = new System.Drawing.Size(101, 30);
            this.btnPreview1.TabIndex = 16;
            this.btnPreview1.Text = "View Request";
            this.btnPreview1.UseVisualStyleBackColor = true;
            this.btnPreview1.Click += new System.EventHandler(this.btnPreview1_Click);
            // 
            // uxHRRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 421);
            this.Controls.Add(this.btnPreview1);
            this.Controls.Add(this.btnPreview2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReqNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Button btnPreview2;
        private System.Windows.Forms.Button btnPreview1;
    }
}