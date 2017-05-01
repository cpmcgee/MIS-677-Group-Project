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
        public uxSeniorManager(Employee user, List<NewHire> hires)
        {
            this.hires = hires;
            User = user;
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
                            dbase.UpdateEquipmentRequestStatus(hire.EquipmentReq.RequestNum, 2);

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
                            dbase.UpdateEquipmentRequestStatus(hire.EquipmentReq.RequestNum, 3);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating equipment request status\n" + ex.Message);
            }
        }

        private void uxDataGridRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lstSoftware.Items.Clear();
            lstHardware.Items.Clear();
            foreach (var hire in hires)
            {
                if (Convert.ToInt32(uxDataGridRequests.SelectedRows[0].Cells[0].Value) == hire.EquipmentReq.RequestNum)
                {
                    for (int i = 0; i < hire.EquipmentReq.SoftwareOptions.Length; i++)
                    {
                        if (hire.EquipmentReq.SoftwareOptions[i])
                        {
                            lstSoftware.Items.Add(softwareOptions[i]);
                        }
                    }

                    for (int i = 0; i < hire.EquipmentReq.HardwareOptions.Length; i++)
                    {
                        if (hire.EquipmentReq.HardwareOptions[i])
                        {
                            lstHardware.Items.Add(hardwareOptions[i]);
                        }
                    }
                    return;
                }
            }
        }
    }
}
