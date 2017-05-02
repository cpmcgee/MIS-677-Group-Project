using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class uxSeniorManager : Form
    {
        Employee User;
        List<NewHire> hires;
        Dictionary<int, string> hardwareOptions = new Dictionary<int, string>();
        Dictionary<int, string> softwareOptions = new Dictionary<int, string>();
        LoginForm parentForm;

        public uxSeniorManager(LoginForm parent, Employee user, List<NewHire> hires)
        {
            this.hires = hires;
            User = user;
            parentForm = parent;
            InitializeComponent();

            hardwareOptions.Add(0, "Laptop");
            hardwareOptions.Add(1, "Desktop");
            hardwareOptions.Add(2, "Monitor");
            hardwareOptions.Add(3, "VGA Cable");
            hardwareOptions.Add(4, "HDMI Cable");
            hardwareOptions.Add(5, "DVI Cable");
            hardwareOptions.Add(6, "Wired Mouse");
            hardwareOptions.Add(7, "Wireless Mouse");
            hardwareOptions.Add(8, "Keyboard");
            hardwareOptions.Add(9, "Ergonomic Keyboard");
            hardwareOptions.Add(10, "Comfort Foot Mat");
            hardwareOptions.Add(11, "Telephone");
            hardwareOptions.Add(12, "Laptop Docking Station");

            softwareOptions.Add(0, "Office 2017 Suite");
            softwareOptions.Add(1, "Project Manager");
            softwareOptions.Add(2, "Prophet DBMS");
            softwareOptions.Add(3, "Seagull Design Pro");
            softwareOptions.Add(4, "Seagull Design Lite");
            softwareOptions.Add(5, "Visual Workroom");
            softwareOptions.Add(6, "GET Version Control");
            softwareOptions.Add(7, "Citrix Reciever");
            softwareOptions.Add(8, "Citrix Dev Console");

            foreach (var hire in hires)
            {
                uxDataGridRequests.Rows.Add(hire.EquipmentReq.RequestNum,
                                            hire.FirstName, hire.LastName,
                                            hire.EquipmentReq.RequestedOn);
            }
        }

        /// <summary>
        /// Event handler for approve button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxApprove_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var hire in hires)
                {
                    if (hire.EquipmentReq.RequestNum == Convert.ToInt32(uxDataGridRequests.SelectedRows[0].Cells[0].Value))
                    {
                        using (ChiltonDB dbase = new ChiltonDB())
                        {
                            hire.EquipmentReq.Status = 2;
                            hire.EquipmentReq.ApprovedOn = DateTime.Now;
                            dbase.UpdateEquipmentRequest(hire.EquipmentReq);

                            //update approval date

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating equipment request status\n" + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for deny button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDeny_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var hire in hires)
                {
                    if (hire.EquipmentReq.RequestNum == Convert.ToInt32(uxDataGridRequests.SelectedRows[0].Cells[0].Value))
                    {
                        using (ChiltonDB dbase = new ChiltonDB())
                        {
                            hire.EquipmentReq.Status = 3;
                            dbase.UpdateEquipmentRequest(hire.EquipmentReq);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating equipment request status\n" + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for logout button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            Close();
        }

        /// <summary>
        /// Event handler for preview button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            foreach (var hire in hires)
            {
                if (Convert.ToInt32(uxDataGridRequests.SelectedRows[0].Cells[0].Value) == hire.EquipmentReq.RequestNum)
                {
                    new OptionPreview(hire.EquipmentReq).Show();
                }
            }
        }
    }
}
