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
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGridRequests
            // 
            this.uxDataGridRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGridRequests.Location = new System.Drawing.Point(12, 44);
            this.uxDataGridRequests.Name = "uxDataGridRequests";
            this.uxDataGridRequests.RowTemplate.Height = 24;
            this.uxDataGridRequests.Size = new System.Drawing.Size(780, 409);
            this.uxDataGridRequests.TabIndex = 0;
            // 
            // uxApprove
            // 
            this.uxApprove.Location = new System.Drawing.Point(12, 459);
            this.uxApprove.Name = "uxApprove";
            this.uxApprove.Size = new System.Drawing.Size(89, 33);
            this.uxApprove.TabIndex = 1;
            this.uxApprove.Text = "Approve";
            this.uxApprove.UseVisualStyleBackColor = true;
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel.Location = new System.Drawing.Point(13, 13);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(429, 25);
            this.uxLabel.TabIndex = 2;
            this.uxLabel.Text = "Current Equipment Requests Needing Approval:";
            // 
            // uxDeny
            // 
            this.uxDeny.Location = new System.Drawing.Point(703, 459);
            this.uxDeny.Name = "uxDeny";
            this.uxDeny.Size = new System.Drawing.Size(89, 33);
            this.uxDeny.TabIndex = 3;
            this.uxDeny.Text = "Deny";
            this.uxDeny.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(703, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 30);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // uxSeniorManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 504);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.uxDeny);
            this.Controls.Add(this.uxLabel);
            this.Controls.Add(this.uxApprove);
            this.Controls.Add(this.uxDataGridRequests);
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
    }
}