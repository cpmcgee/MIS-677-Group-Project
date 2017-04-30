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
    public partial class uxHRRep : Form
    {
        JsonDataObject[] unAssignedHires;
        List<Supervisor> supervisors;
        Employee User;
        public uxHRRep(Employee user, List<Supervisor> supervisors, JsonDataObject[] jsonData, List<NewHire> hires)
        {
            InitializeComponent();
            User = user;
            this.supervisors = supervisors;
            unAssignedHires = jsonData;
            foreach (var hire in jsonData)
            {
                lstUnnasigned.Items.Add(hire.firstName + " " + hire.lastName);
            }

            foreach (var s in supervisors)
            {
                if (s.IsAvailable)
                {
                    lstSupervisors.Items.Add(s.FirstName + " " + s.LastName);
                }
            }

            foreach (var hire in hires)
            {
                using (ChiltonDB dbase = new ChiltonDB())
                {
                    if (hire.EquipmentReq.Status == 0)
                    {
                        uxGridViewRequests.Rows.Add(hire.EquipmentReq.RequestNum, hire.FirstName,
                                                    hire.LastName, hire.EquipmentReq.RequestedOn,
                                                    dbase.GetEmployeeName(hire.EquipmentReq.RequestedBy),
                                                    "Requested");
                    }
                    else if (hire.EquipmentReq.Status == 2)
                    {
                        uxGridViewRequests.Rows.Add(hire.EquipmentReq.RequestNum, hire.FirstName,
                                                    hire.LastName, hire.EquipmentReq.RequestedOn,
                                                    dbase.GetEmployeeName(hire.EquipmentReq.RequestedBy),
                                                    "Approved");
                    }
                    else if (hire.EquipmentReq.Status == 5)
                    {
                        uxGridViewCompleted.Rows.Add(hire.EquipmentReq.RequestNum, hire.LastName, hire.EquipmentReq.CompletedOn);
                    }
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            { 
                using (ChiltonDB dbase = new ChiltonDB())
                {
                    JsonDataObject unh = MatchHire((string)lstUnnasigned.SelectedItem);
                    int spvNum = MatchSupervisor((string)lstSupervisors.SelectedItem);
                    NewHire nh = new NewHire(dbase.GetNewHireNumber(), unh.firstName, unh.lastName, unh.sex, Convert.ToDateTime(unh.dateOfBirth), spvNum);
                    dbase.InsertNewHire(nh);
                }
                lstUnnasigned.Items.Remove(lstUnnasigned.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private JsonDataObject MatchHire(string selectedHire)
        {
            foreach (var unh in unAssignedHires)
            {
                if (unh.firstName + " " + unh.lastName == selectedHire)
                    return unh;
            }
            return null;
        }

        private int MatchSupervisor(string selectedSupervisor)
        {
            foreach (var sup in supervisors)
            {
                if (sup.FirstName + " " + sup.LastName == selectedSupervisor)
                    return sup.EmployeeNum;
            }
            return default(int);
        }

        private void btnSendToManager_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = uxGridViewRequests.Rows.GetRowCount(DataGridViewElementStates.Selected);
                using (ChiltonDB dbase = new ChiltonDB())
                {
                    foreach (DataGridViewRow row in uxGridViewRequests.SelectedRows)
                    {
                        if ((string)row.Cells[5].Value == "Requested")
                        {
                            dbase.UpdateEquipmentRequestStatus((int)row.Cells[0].Value, 1);
                            row.Cells[5].Value = "Sent to Manager";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSendToBuildTeam_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = uxGridViewRequests.Rows.GetRowCount(DataGridViewElementStates.Selected);
                using (ChiltonDB dbase = new ChiltonDB())
                {
                    foreach (DataGridViewRow row in uxGridViewRequests.SelectedRows)
                    {
                        if ((string)row.Cells[5].Value == "Approved")
                        {
                            dbase.UpdateEquipmentRequestStatus((int)row.Cells[0].Value, 4);
                            row.Cells[5].Value = "Sent to Build Team";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = uxGridViewCompleted.Rows.GetRowCount(DataGridViewElementStates.Selected);
                using (ChiltonDB dbase = new ChiltonDB())
                {
                    foreach (DataGridViewRow row in uxGridViewCompleted.SelectedRows)
                    {
                        dbase.UpdateEquipmentRequestStatus((int)row.Cells[0].Value, 6);
                        uxGridViewCompleted.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelay_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = uxGridViewCompleted.Rows.GetRowCount(DataGridViewElementStates.Selected);
                using (ChiltonDB dbase = new ChiltonDB())
                {
                    foreach (DataGridViewRow row in uxGridViewCompleted.SelectedRows)
                    {
                        dbase.UpdateEquipmentRequestStatus((int)row.Cells[0].Value, 4);
                        uxGridViewCompleted.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
