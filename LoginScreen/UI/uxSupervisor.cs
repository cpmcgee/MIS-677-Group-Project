﻿using System;
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
    public partial class uxSupervisor : Form
    {
        List<NewHire> hires;
        Employee User;
        LoginForm parentForm;

        public uxSupervisor(LoginForm parent, Employee user, List<NewHire> hires)
        {
            InitializeComponent();
            parentForm = parent;
            User = user;
            this.hires = hires;
            foreach (var hire in hires)
            {
                using (ChiltonDB dbase = new ChiltonDB())
                {
                    if (hire.EquipmentReq == null)
                    {
                       uxGridNewHires.Rows.Add(hire.FirstName, hire.LastName, hire.NewHireNum);
                    }
                    else if (hire.EquipmentReq.Status == 3)
                    {
                        uxGridDenied.Rows.Add(hire.EquipmentReq.RequestNum, hire.FirstName,
                                                    hire.LastName);
                    }
                    else if (hire.EquipmentReq.Status == 6)
                    {
                        uxGridNewHires.Rows.Add(hire.EquipmentReq.RequestNum, hire.FirstName, hire.LastName, hire.EquipmentReq.CompletedOn);
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for submit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            foreach (var hire in hires)
            {
                if (hire.NewHireNum == (int)uxGridNewHires.SelectedRows[0].Cells[2].Value)
                {
                    try
                    {
                        hire.AssignRequest(CreateSoftwareRequest(), CreateHardwareRequest());
                        uxGridNewHires.Rows.Remove(uxGridNewHires.SelectedRows[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error assigning equipment request\n" + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Creates a hardware request from the checked boxes
        /// </summary>
        /// <returns></returns>
        private bool[] CreateHardwareRequest()
        {
            bool[] sw = new bool[9];
            for(int i = 0; i < chckLstHardware.Items.Count; i++)
            {
                sw[i] = chckLstHardware.GetItemChecked(i);
            }
            return sw;
        }

        /// <summary>
        /// Creates a software request from the checked boxes
        /// </summary>
        /// <returns></returns>
        private bool[] CreateSoftwareRequest()
        {
            bool[] hw = new bool[13];
            for (int i = 0; i < chckLstSoftware.Items.Count; i++)
            {
                hw[i] = chckLstSoftware.GetItemChecked(i);
            }
            return hw;
        }

        /// <summary>
        /// Event handler for clear button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            chckLstSoftware.ClearSelected();
            chckLstHardware.ClearSelected();
        }

        /// <summary>
        /// Event handler for other clear button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear2_Click(object sender, EventArgs e)
        {
            chckLstSoftware.ClearSelected();
            chckLstHardware.ClearSelected();
        }

        /// <summary>
        /// Event handler for remove button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                using (ChiltonDB dbase = new ChiltonDB())
                {
                    var row = uxGridNewHires.SelectedRows[0];
                    dbase.DeleteEquipmentRequest((int)row.Cells[0].Value);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error removing request\n" + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for resubmit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResubmit_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var hire in hires)
                {
                    if (hire.EquipmentReq.RequestNum == (int)uxGridDenied.SelectedRows[0].Cells[0].Value)
                    {
                        using (ChiltonDB dbase = new ChiltonDB())
                        {
                            hire.EquipmentReq.Status = 4;
                            hire.EquipmentReq.SoftwareOptions = CreateSoftwareRequest();
                            hire.EquipmentReq.HardwareOptions = CreateHardwareRequest();
                            dbase.EditEquipmentRequest(hire.EquipmentReq);
                            dbase.UpdateEquipmentRequest(hire.EquipmentReq);
                            uxGridNewHires.Rows.Remove(uxGridNewHires.SelectedRows[0]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning equipment request\n" + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for pickup button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPickup_Click(object sender, EventArgs e)
        {
            foreach (var hire in hires)
            {
                if (hire.EquipmentReq.RequestNum == (int)uxGridPickup.SelectedRows[0].Cells[0].Value)
                {
                    using (ChiltonDB dbase = new ChiltonDB())
                    {
                        hire.EquipmentReq.Status = 7;
                        dbase.UpdateEquipmentRequest(hire.EquipmentReq);
                        uxGridPickup.Rows.Remove(uxGridPickup.SelectedRows[0]);
                    }
                }
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
                if (Convert.ToInt32(uxGridDenied.SelectedRows[0].Cells[0].Value) == hire.EquipmentReq.RequestNum)
                {
                    new OptionPreview(hire.EquipmentReq).Show();
                }
            }
        }
    }
}
