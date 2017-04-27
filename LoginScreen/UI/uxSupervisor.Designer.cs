namespace GroupProject
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
            this.uxGridNewHires = new System.Windows.Forms.DataGridView();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.uxGridDenied = new System.Windows.Forms.DataGridView();
            this.lblDenied = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnResubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPickUp = new System.Windows.Forms.Label();
            this.btnPickup = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridNewHires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridDenied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewHires
            // 
            this.lblNewHires.AutoSize = true;
            this.lblNewHires.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewHires.Location = new System.Drawing.Point(12, 9);
            this.lblNewHires.Name = "lblNewHires";
            this.lblNewHires.Size = new System.Drawing.Size(101, 25);
            this.lblNewHires.TabIndex = 1;
            this.lblNewHires.Text = "New Hires";
            // 
            // chckLstSoftware
            // 
            this.chckLstSoftware.FormattingEnabled = true;
            this.chckLstSoftware.Location = new System.Drawing.Point(17, 181);
            this.chckLstSoftware.Name = "chckLstSoftware";
            this.chckLstSoftware.Size = new System.Drawing.Size(267, 174);
            this.chckLstSoftware.TabIndex = 2;
            // 
            // chckLstHardware
            // 
            this.chckLstHardware.FormattingEnabled = true;
            this.chckLstHardware.Location = new System.Drawing.Point(290, 181);
            this.chckLstHardware.Name = "chckLstHardware";
            this.chckLstHardware.Size = new System.Drawing.Size(266, 174);
            this.chckLstHardware.TabIndex = 3;
            // 
            // uxGridNewHires
            // 
            this.uxGridNewHires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridNewHires.Location = new System.Drawing.Point(17, 37);
            this.uxGridNewHires.Name = "uxGridNewHires";
            this.uxGridNewHires.RowTemplate.Height = 24;
            this.uxGridNewHires.Size = new System.Drawing.Size(539, 138);
            this.uxGridNewHires.TabIndex = 4;
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Location = new System.Drawing.Point(17, 362);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(128, 33);
            this.btnSubmitRequest.TabIndex = 5;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = true;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(428, 362);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Options";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // uxGridDenied
            // 
            this.uxGridDenied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridDenied.Location = new System.Drawing.Point(188, 432);
            this.uxGridDenied.Name = "uxGridDenied";
            this.uxGridDenied.RowTemplate.Height = 24;
            this.uxGridDenied.Size = new System.Drawing.Size(355, 138);
            this.uxGridDenied.TabIndex = 7;
            // 
            // lblDenied
            // 
            this.lblDenied.AutoSize = true;
            this.lblDenied.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenied.Location = new System.Drawing.Point(10, 432);
            this.lblDenied.Name = "lblDenied";
            this.lblDenied.Size = new System.Drawing.Size(161, 25);
            this.lblDenied.TabIndex = 8;
            this.lblDenied.Text = "Denied Requests";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(15, 460);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(156, 33);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(15, 499);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 33);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit Request";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnResubmit
            // 
            this.btnResubmit.Location = new System.Drawing.Point(15, 537);
            this.btnResubmit.Name = "btnResubmit";
            this.btnResubmit.Size = new System.Drawing.Size(156, 33);
            this.btnResubmit.TabIndex = 11;
            this.btnResubmit.Text = "Re-Submit";
            this.btnResubmit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(588, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(419, 321);
            this.dataGridView1.TabIndex = 12;
            // 
            // lblPickUp
            // 
            this.lblPickUp.AutoSize = true;
            this.lblPickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickUp.Location = new System.Drawing.Point(583, 108);
            this.lblPickUp.Name = "lblPickUp";
            this.lblPickUp.Size = new System.Drawing.Size(236, 25);
            this.lblPickUp.TabIndex = 13;
            this.lblPickUp.Text = "Requests to be Picked Up";
            // 
            // btnPickup
            // 
            this.btnPickup.Location = new System.Drawing.Point(588, 463);
            this.btnPickup.Name = "btnPickup";
            this.btnPickup.Size = new System.Drawing.Size(419, 33);
            this.btnPickup.TabIndex = 14;
            this.btnPickup.Text = "Mark as Picked Up";
            this.btnPickup.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(932, 11);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 26);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // uxSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 599);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPickup);
            this.Controls.Add(this.lblPickUp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnResubmit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblDenied);
            this.Controls.Add(this.uxGridDenied);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.uxGridNewHires);
            this.Controls.Add(this.chckLstHardware);
            this.Controls.Add(this.chckLstSoftware);
            this.Controls.Add(this.lblNewHires);
            this.Name = "uxSupervisor";
            this.Text = "Dashboard - Supervisor";
            this.Load += new System.EventHandler(this.uxSupervisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxGridNewHires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridDenied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNewHires;
        private System.Windows.Forms.CheckedListBox chckLstSoftware;
        private System.Windows.Forms.CheckedListBox chckLstHardware;
        private System.Windows.Forms.DataGridView uxGridNewHires;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView uxGridDenied;
        private System.Windows.Forms.Label lblDenied;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnResubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPickUp;
        private System.Windows.Forms.Button btnPickup;
        private System.Windows.Forms.Button btnLogout;
    }
}