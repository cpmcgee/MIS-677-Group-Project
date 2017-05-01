namespace GroupProject
{
    partial class uxSeniorManager
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
            this.uxDataGridRequests = new System.Windows.Forms.DataGridView();
            this.uxApprove = new System.Windows.Forms.Button();
            this.uxLabel = new System.Windows.Forms.Label();
            this.uxDeny = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstHardware = new System.Windows.Forms.ListBox();
            this.lstSoftware = new System.Windows.Forms.ListBox();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReqDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGridRequests
            // 
            this.uxDataGridRequests.AllowUserToAddRows = false;
            this.uxDataGridRequests.AllowUserToDeleteRows = false;
            this.uxDataGridRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uxDataGridRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGridRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colFirst,
            this.colLast,
            this.colReqDate});
            this.uxDataGridRequests.Location = new System.Drawing.Point(9, 36);
            this.uxDataGridRequests.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxDataGridRequests.MultiSelect = false;
            this.uxDataGridRequests.Name = "uxDataGridRequests";
            this.uxDataGridRequests.RowTemplate.Height = 24;
            this.uxDataGridRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxDataGridRequests.Size = new System.Drawing.Size(419, 221);
            this.uxDataGridRequests.TabIndex = 0;
            this.uxDataGridRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxDataGridRequests_CellContentClick);
            // 
            // uxApprove
            // 
            this.uxApprove.Location = new System.Drawing.Point(9, 261);
            this.uxApprove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxApprove.Name = "uxApprove";
            this.uxApprove.Size = new System.Drawing.Size(67, 27);
            this.uxApprove.TabIndex = 1;
            this.uxApprove.Text = "Approve";
            this.uxApprove.UseVisualStyleBackColor = true;
            this.uxApprove.Click += new System.EventHandler(this.uxApprove_Click);
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel.Location = new System.Drawing.Point(10, 11);
            this.uxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(349, 20);
            this.uxLabel.TabIndex = 2;
            this.uxLabel.Text = "Current Equipment Requests Needing Approval:";
            // 
            // uxDeny
            // 
            this.uxDeny.Location = new System.Drawing.Point(361, 261);
            this.uxDeny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxDeny.Name = "uxDeny";
            this.uxDeny.Size = new System.Drawing.Size(67, 27);
            this.uxDeny.TabIndex = 3;
            this.uxDeny.Text = "Deny";
            this.uxDeny.UseVisualStyleBackColor = true;
            this.uxDeny.Click += new System.EventHandler(this.uxDeny_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(715, 7);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(67, 24);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lstHardware
            // 
            this.lstHardware.FormattingEnabled = true;
            this.lstHardware.Location = new System.Drawing.Point(609, 35);
            this.lstHardware.Margin = new System.Windows.Forms.Padding(2);
            this.lstHardware.Name = "lstHardware";
            this.lstHardware.Size = new System.Drawing.Size(173, 251);
            this.lstHardware.TabIndex = 6;
            // 
            // lstSoftware
            // 
            this.lstSoftware.FormattingEnabled = true;
            this.lstSoftware.Location = new System.Drawing.Point(432, 36);
            this.lstSoftware.Margin = new System.Windows.Forms.Padding(2);
            this.lstSoftware.Name = "lstSoftware";
            this.lstSoftware.Size = new System.Drawing.Size(173, 251);
            this.lstSoftware.TabIndex = 5;
            // 
            // colNum
            // 
            this.colNum.HeaderText = "Request #";
            this.colNum.Name = "colNum";
            this.colNum.Width = 82;
            // 
            // colFirst
            // 
            this.colFirst.HeaderText = "First Name";
            this.colFirst.Name = "colFirst";
            this.colFirst.Width = 82;
            // 
            // colLast
            // 
            this.colLast.HeaderText = "Last Name";
            this.colLast.Name = "colLast";
            this.colLast.Width = 83;
            // 
            // colReqDate
            // 
            this.colReqDate.HeaderText = "Requested On";
            this.colReqDate.Name = "colReqDate";
            this.colReqDate.Width = 101;
            // 
            // uxSeniorManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 297);
            this.Controls.Add(this.lstHardware);
            this.Controls.Add(this.lstSoftware);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.uxDeny);
            this.Controls.Add(this.uxLabel);
            this.Controls.Add(this.uxApprove);
            this.Controls.Add(this.uxDataGridRequests);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uxSeniorManager";
            this.Text = "Dashboard - Senior Manager";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGridRequests;
        private System.Windows.Forms.Button uxApprove;
        private System.Windows.Forms.Label uxLabel;
        private System.Windows.Forms.Button uxDeny;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListBox lstHardware;
        private System.Windows.Forms.ListBox lstSoftware;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReqDate;
    }
}