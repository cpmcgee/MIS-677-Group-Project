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
    public partial class uxHRRep : Form
    {
        JsonDataObject[] unAssignedHires;
        List<Supervisor> supervisors;
        List<NewHire> hires;
        Employee User;
        LoginForm parentForm;

        public uxHRRep(LoginForm parent, Employee user, List<Supervisor> supervisors, JsonDataObject[] jsonData, List<NewHire> hires)
        {
            InitializeComponent();
            parentForm = parent;
            User = user;
            this.hires = hires;
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
                                                    hire.LastName, String.Format("{0:MM/dd/yy}", hire.EquipmentReq.RequestedOn),
                                                    dbase.GetEmployeeName(hire.EquipmentReq.RequestedBy),
                                                    "Requested");
                    }
                    else if (hire.EquipmentReq.Status == 2)
                    {
                        uxGridViewRequests.Rows.Add(hire.EquipmentReq.RequestNum, hire.FirstName,
                                                    hire.LastName, String.Format("{0:MM/dd/yy}", hire.EquipmentReq.RequestedOn),
                                                    dbase.GetEmployeeName(hire.EquipmentReq.RequestedBy),
                                                    "Approved");
                    }
                    else if (hire.EquipmentReq.Status == 5)
                    {
                        uxGridViewCompleted.Rows.Add(hire.EquipmentReq.RequestNum, hire.LastName, String.Format("{0:MM/dd/yy}", hire.EquipmentReq.CompletedOn));
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for assign button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            { 
                using (ChiltonDB dbase = new ChiltonDB())
                {
                    JsonDataObject unh = MatchHire((string)lstUnnasigned.SelectedItem);
                    int spvNum = MatchSupervisor((string)lstSupervisors.SelectedItem);
                    NEWHIRE nh = new NEWHIRE
                    {
                        FIRSTNAME = unh.firstName,
                        LASTNAME = unh.lastName,
                        DATE_OF_BIRTH = Convert.ToDateTime(unh.dateOfBirth),
                        GENDER = unh.sex,
                        SUPERVISOR_NUM = spvNum,
                        NEWHIRE_NUM = dbase.GetNewHireNumber(),
                        BACKGROUND_PASSED = Convert.ToBoolean(unh.backgroundStatus == "Passed" ? "true" : "false")
                    };
                        
                        //dbase.GetNewHireNumber(), unh.firstName, unh.lastName, unh.sex, Convert.ToDateTime(unh.dateOfBirth), spvNum);
                    dbase.NEWHIREs.InsertOnSubmit(nh);
                    dbase.SubmitChanges();
                }
                lstUnnasigned.Items.Remove(lstUnnasigned.SelectedItem);
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show("Please select a new hire and a supervisor");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Finds a hire from the one selected on the list
        /// </summary>
        /// <param name="selectedHire"></param>
        /// <returns></returns>
        private JsonDataObject MatchHire(string selectedHire)
        {
            foreach (var unh in unAssignedHires)
            {
                if (unh.firstName + " " + unh.lastName == selectedHire)
                    return unh;
            }
            return null;
        }

        /// <summary>
        /// Finds a supervisor based on the one selected on the list
        /// </summary>
        /// <param name="selectedSupervisor"></param>
        /// <returns></returns>
        private int MatchSupervisor(string selectedSupervisor)
        {
            foreach (var sup in supervisors)
            {
                if (sup.FirstName + " " + sup.LastName == selectedSupervisor)
                    return sup.EmployeeNum;
            }
            return default(int);
        }

        /// <summary>
        /// Event handler for send button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            var updatedRequest = dbase.GetEquipmentRequestByNum((int)row.Cells[0].Value);
                            updatedRequest.Status = 1;
                            dbase.UpdateEquipmentRequest(updatedRequest);
                            row.Cells[5].Value = "Sent to Manager";
                            return;
                        }
                    }
                    MessageBox.Show("Request already approved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Event handler for send to build team button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            var updatedRequest = dbase.GetEquipmentRequestByNum((int)row.Cells[0].Value);
                            updatedRequest.Status = 4;
                            dbase.UpdateEquipmentRequest(updatedRequest);
                            row.Cells[5].Value = "Sent to Build Team";
                            return;
                        }
                    }
                    MessageBox.Show("Request not ready to send to build team.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Event handler for approve button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = uxGridViewCompleted.Rows.GetRowCount(DataGridViewElementStates.Selected);
                using (ChiltonDB dbase = new ChiltonDB())
                {
                    foreach (DataGridViewRow row in uxGridViewCompleted.SelectedRows)
                    { 
                        var updatedRequest = dbase.GetEquipmentRequestByNum((int)row.Cells[0].Value);
                        updatedRequest.Status = 6;
                        dbase.UpdateEquipmentRequest(updatedRequest);
                        uxGridViewCompleted.Rows.Remove(row);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Event handler for delay button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelay_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = uxGridViewCompleted.Rows.GetRowCount(DataGridViewElementStates.Selected);
                using (ChiltonDB dbase = new ChiltonDB())
                {
                    foreach (DataGridViewRow row in uxGridViewCompleted.SelectedRows)
                    {
                        var updatedRequest = dbase.GetEquipmentRequestByNum((int)row.Cells[0].Value);
                        updatedRequest.Status = 4;
                        dbase.UpdateEquipmentRequest(updatedRequest);
                        uxGridViewCompleted.Rows.Remove(row);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (Convert.ToInt32(uxGridViewRequests.SelectedRows[0].Cells[0].Value) == hire.EquipmentReq.RequestNum)
                {
                    new OptionPreview(hire.EquipmentReq).Show();
                }
            }
        }

        /// <summary>
        /// Event handler for other preview button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreview1_Click(object sender, EventArgs e)
        {
            foreach (var hire in hires)
            {
                if (Convert.ToInt32(uxGridViewCompleted.SelectedRows[0].Cells[0].Value) == hire.EquipmentReq.RequestNum)
                {
                    new OptionPreview(hire.EquipmentReq).Show();
                }
            }
        }
    }
}
