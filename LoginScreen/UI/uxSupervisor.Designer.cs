﻿namespace GroupProject
{
    partial class uxSupervisor
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
            this.lblNewHires = new System.Windows.Forms.Label();
            this.chckLstSoftware = new System.Windows.Forms.CheckedListBox();
            this.chckLstHardware = new System.Windows.Forms.CheckedListBox();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.uxGridDenied = new System.Windows.Forms.DataGridView();
            this.colReqNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirst2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLast2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDenied = new System.Windows.Forms.Label();
            this.btnResubmit = new System.Windows.Forms.Button();
            this.uxGridPickup = new System.Windows.Forms.DataGridView();
            this.colReqNum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirst3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLast3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompleteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPickUp = new System.Windows.Forms.Label();
            this.btnPickup = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.lblSoftware = new System.Windows.Forms.Label();
            this.lblHardware = new System.Windows.Forms.Label();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLast1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirst1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxGridNewHires = new System.Windows.Forms.DataGridView();
            this.btnPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridDenied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridPickup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridNewHires)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewHires
            // 
            this.lblNewHires.AutoSize = true;
            this.lblNewHires.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewHires.Location = new System.Drawing.Point(469, 5);
            this.lblNewHires.Name = "lblNewHires";
            this.lblNewHires.Size = new System.Drawing.Size(101, 25);
            this.lblNewHires.TabIndex = 1;
            this.lblNewHires.Text = "New Hires";
            // 
            // chckLstSoftware
            // 
            this.chckLstSoftware.FormattingEnabled = true;
            this.chckLstSoftware.Items.AddRange(new object[] {
            "Office 2017 Suite",
            "Project Manager",
            "Prophet DBMS",
            "Seagull Design Pro",
            "Seagull Design Lite",
            "Visual Workroom",
            "GET Version Control",
            "Citrix Reciever",
            "Citrix Dev Console"});
            this.chckLstSoftware.Location = new System.Drawing.Point(15, 32);
            this.chckLstSoftware.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chckLstSoftware.Name = "chckLstSoftware";
            this.chckLstSoftware.Size = new System.Drawing.Size(220, 361);
            this.chckLstSoftware.TabIndex = 2;
            // 
            // chckLstHardware
            // 
            this.chckLstHardware.FormattingEnabled = true;
            this.chckLstHardware.Items.AddRange(new object[] {
            "Laptop",
            "Desktop",
            "Monitor",
            "VGA Cable",
            "HDMI Cable",
            "DVI Cable",
            "Wired Mouse",
            "Wireless Mouse",
            "Keyboard",
            "Ergonomic Keyboard",
            "Comfort Foot Mat",
            "Telephone",
            "Laptop Docking Station"});
            this.chckLstHardware.Location = new System.Drawing.Point(241, 32);
            this.chckLstHardware.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chckLstHardware.Name = "chckLstHardware";
            this.chckLstHardware.Size = new System.Drawing.Size(220, 361);
            this.chckLstHardware.TabIndex = 3;
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Location = new System.Drawing.Point(853, 130);
            this.btnSubmitRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(124, 33);
            this.btnSubmitRequest.TabIndex = 5;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = true;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(853, 169);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Options";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // uxGridDenied
            // 
            this.uxGridDenied.AllowUserToAddRows = false;
            this.uxGridDenied.AllowUserToDeleteRows = false;
            this.uxGridDenied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridDenied.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReqNum,
            this.colFirst2,
            this.colLast2});
            this.uxGridDenied.Location = new System.Drawing.Point(469, 231);
            this.uxGridDenied.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxGridDenied.MultiSelect = false;
            this.uxGridDenied.Name = "uxGridDenied";
            this.uxGridDenied.RowTemplate.Height = 24;
            this.uxGridDenied.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxGridDenied.Size = new System.Drawing.Size(379, 175);
            this.uxGridDenied.TabIndex = 7;
            // 
            // colReqNum
            // 
            this.colReqNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colReqNum.HeaderText = "Request #";
            this.colReqNum.Name = "colReqNum";
            this.colReqNum.Width = 102;
            // 
            // colFirst2
            // 
            this.colFirst2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFirst2.HeaderText = "First Name";
            this.colFirst2.Name = "colFirst2";
            this.colFirst2.Width = 105;
            // 
            // colLast2
            // 
            this.colLast2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLast2.HeaderText = "Last Name";
            this.colLast2.Name = "colLast2";
            this.colLast2.Width = 105;
            // 
            // lblDenied
            // 
            this.lblDenied.AutoSize = true;
            this.lblDenied.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenied.Location = new System.Drawing.Point(469, 204);
            this.lblDenied.Name = "lblDenied";
            this.lblDenied.Size = new System.Drawing.Size(161, 25);
            this.lblDenied.TabIndex = 8;
            this.lblDenied.Text = "Denied Requests";
            // 
            // btnResubmit
            // 
            this.btnResubmit.Location = new System.Drawing.Point(853, 335);
            this.btnResubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResubmit.Name = "btnResubmit";
            this.btnResubmit.Size = new System.Drawing.Size(125, 33);
            this.btnResubmit.TabIndex = 11;
            this.btnResubmit.Text = "Re-Submit";
            this.btnResubmit.UseVisualStyleBackColor = true;
            this.btnResubmit.Click += new System.EventHandler(this.btnResubmit_Click);
            // 
            // uxGridPickup
            // 
            this.uxGridPickup.AllowUserToAddRows = false;
            this.uxGridPickup.AllowUserToDeleteRows = false;
            this.uxGridPickup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridPickup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReqNum2,
            this.colFirst3,
            this.colLast3,
            this.colCompleteDate});
            this.uxGridPickup.Location = new System.Drawing.Point(123, 442);
            this.uxGridPickup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxGridPickup.MultiSelect = false;
            this.uxGridPickup.Name = "uxGridPickup";
            this.uxGridPickup.RowTemplate.Height = 24;
            this.uxGridPickup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxGridPickup.Size = new System.Drawing.Size(524, 167);
            this.uxGridPickup.TabIndex = 12;
            // 
            // colReqNum2
            // 
            this.colReqNum2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colReqNum2.HeaderText = "Request #";
            this.colReqNum2.Name = "colReqNum2";
            this.colReqNum2.Width = 102;
            // 
            // colFirst3
            // 
            this.colFirst3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFirst3.HeaderText = "First Name";
            this.colFirst3.Name = "colFirst3";
            this.colFirst3.Width = 105;
            // 
            // colLast3
            // 
            this.colLast3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLast3.HeaderText = "Last Name";
            this.colLast3.Name = "colLast3";
            this.colLast3.Width = 105;
            // 
            // colCompleteDate
            // 
            this.colCompleteDate.HeaderText = "Completed On";
            this.colCompleteDate.Name = "colCompleteDate";
            // 
            // lblPickUp
            // 
            this.lblPickUp.AutoSize = true;
            this.lblPickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickUp.Location = new System.Drawing.Point(195, 415);
            this.lblPickUp.Name = "lblPickUp";
            this.lblPickUp.Size = new System.Drawing.Size(236, 25);
            this.lblPickUp.TabIndex = 13;
            this.lblPickUp.Text = "Requests to be Picked Up";
            // 
            // btnPickup
            // 
            this.btnPickup.Location = new System.Drawing.Point(652, 522);
            this.btnPickup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPickup.Name = "btnPickup";
            this.btnPickup.Size = new System.Drawing.Size(172, 33);
            this.btnPickup.TabIndex = 14;
            this.btnPickup.Text = "Mark as Picked Up";
            this.btnPickup.UseVisualStyleBackColor = true;
            this.btnPickup.Click += new System.EventHandler(this.btnPickup_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(904, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 26);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(853, 373);
            this.btnClear2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(125, 33);
            this.btnClear2.TabIndex = 16;
            this.btnClear2.Text = "Clear Options";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftware.Location = new System.Drawing.Point(15, 5);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(162, 25);
            this.lblSoftware.TabIndex = 17;
            this.lblSoftware.Text = "Software Options";
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardware.Location = new System.Drawing.Point(236, 5);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(169, 25);
            this.lblHardware.TabIndex = 18;
            this.lblHardware.Text = "Hardware Options";
            // 
            // ColNum
            // 
            this.ColNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNum.HeaderText = "Hire #";
            this.ColNum.Name = "ColNum";
            this.ColNum.Width = 75;
            // 
            // colLast1
            // 
            this.colLast1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLast1.HeaderText = "Last Name";
            this.colLast1.Name = "colLast1";
            this.colLast1.Width = 105;
            // 
            // colFirst1
            // 
            this.colFirst1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFirst1.HeaderText = "First Name";
            this.colFirst1.Name = "colFirst1";
            this.colFirst1.Width = 105;
            // 
            // uxGridNewHires
            // 
            this.uxGridNewHires.AllowUserToAddRows = false;
            this.uxGridNewHires.AllowUserToDeleteRows = false;
            this.uxGridNewHires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridNewHires.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirst1,
            this.colLast1,
            this.ColNum});
            this.uxGridNewHires.Location = new System.Drawing.Point(469, 32);
            this.uxGridNewHires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxGridNewHires.MultiSelect = false;
            this.uxGridNewHires.Name = "uxGridNewHires";
            this.uxGridNewHires.RowTemplate.Height = 24;
            this.uxGridNewHires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxGridNewHires.Size = new System.Drawing.Size(379, 170);
            this.uxGridNewHires.TabIndex = 4;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(852, 298);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(129, 31);
            this.btnPreview.TabIndex = 19;
            this.btnPreview.Text = "View Request";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // uxSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 625);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lblHardware);
            this.Controls.Add(this.lblSoftware);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPickup);
            this.Controls.Add(this.lblPickUp);
            this.Controls.Add(this.uxGridPickup);
            this.Controls.Add(this.btnResubmit);
            this.Controls.Add(this.lblDenied);
            this.Controls.Add(this.uxGridDenied);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.uxGridNewHires);
            this.Controls.Add(this.chckLstHardware);
            this.Controls.Add(this.chckLstSoftware);
            this.Controls.Add(this.lblNewHires);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uxSupervisor";
            this.Text = "Dashboard - Supervisor";
            ((System.ComponentModel.ISupportInitialize)(this.uxGridDenied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridPickup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridNewHires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNewHires;
        private System.Windows.Forms.CheckedListBox chckLstSoftware;
        private System.Windows.Forms.CheckedListBox chckLstHardware;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView uxGridDenied;
        private System.Windows.Forms.Label lblDenied;
        private System.Windows.Forms.Button btnResubmit;
        private System.Windows.Forms.DataGridView uxGridPickup;
        private System.Windows.Forms.Label lblPickUp;
        private System.Windows.Forms.Button btnPickup;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.Label lblHardware;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReqNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirst2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLast2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReqNum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirst3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLast3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompleteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLast1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirst1;
        private System.Windows.Forms.DataGridView uxGridNewHires;
        private System.Windows.Forms.Button btnPreview;
    }
}