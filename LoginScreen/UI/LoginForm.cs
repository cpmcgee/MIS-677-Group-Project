using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace GroupProject
{
    public partial class LoginForm : Form
    {
        bool validUser = false;
        bool validPass = false;
        bool validAcct = false;
        string inUser;
        string inPass;
        int _ct = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //TODO:
           //Debug front end and backend logic
           //Re-load data, some hardware and software requests mixed up and causing index out of bounds
           //Add date fields to equipmentrequest db: requested on, completed on, approved on to view tables
           //Add update and insert for above fields
           
        }
        
        /// <summary>
        /// Handles login button, looks up user, displays correct form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (ChiltonDB dbase = new ChiltonDB())
            {
                try
                {
                    inUser = txtUsername.Text;
                    inPass = txtPassword.Text;
                    string inID = null;
                    string pass = null;

                    if (inUser.Contains("\"") || inPass.Contains("\""))
                    {
                        MessageBox.Show("Username and Password field cannot contain quotation marks.");
                        _ct++;
                    }
                    else
                    {
                        foreach (USER u in dbase.USERs) //loop through database table to check for user
                        {
                            string user = u.USER_ID;
                            inID = u.USER_NUM.ToString();
                            if (user == inUser)
                            {
                                validUser = true;
                                pass = u.PASSWORD; //save users actual password
                                break;
                            }
                        }

                        if (pass == inPass) //check if valid password matches password from textbox
                        {
                            validPass = true;
                        }
                        if (validUser && validPass)
                        {
                            validAcct = true;
                        }

                        if (validAcct)
                        {
                            Authenticate(inUser, inPass); //let user in
                        }
                        else
                        {
                            Suspend(); //reset form, lock user out if 3 failed attempts
                        }
                    }
                    
                    validPass = false;
                    validUser = false;
                    validAcct = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// accept user, show form relevant to their position
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        private void Authenticate(string username, string password)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            using (ChiltonDB dbase = new ChiltonDB())
            {
                try
                {
                    var user = dbase.GetUser(username, password);
                    Login(user, dbase);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Below overload methods grab correct data and display correct form
        /// </summary>
        /// <param name="user"></param>
        /// <param name="dbase"></param>
        private void Login(BuildTeamMember user, ChiltonDB dbase)
        {
            List<EquipmentRequest> buildTeamRequests = dbase.GetBuildTeamData();
            uxBuildTeam form = new uxBuildTeam(this, user, buildTeamRequests);
            form.Show();
            Hide();
        }

        private void Login(Supervisor user, ChiltonDB dbase)
        {
            List<NewHire> hires  = dbase.GetSupervisorData();
            uxSupervisor form = new uxSupervisor(this, user, hires);
            form.Show();
            Hide();
        }

        private void Login(HRRep user, ChiltonDB dbase)
        {
            var ser = new JavaScriptSerializer();
            JsonDataObject[] jsonData = ser.Deserialize<JsonDataObject[]>(File.ReadAllText(@"C:\Users\Chris\Desktop\School\_SPRING 2017\MIS 677\Group Project Solution\data.json"));
            List<Supervisor> supervisors;
            List<NewHire> hires = dbase.GetHRData(out supervisors);
            uxHRRep form = new uxHRRep(this, user, supervisors, jsonData, hires);
            form.Show();
            Hide();
        }

        private void Login(Manager user, ChiltonDB dbase)
        {
            List<NewHire> hires = dbase.GetManagerData();
            uxSeniorManager form = new uxSeniorManager(this, user, hires);
            form.Show();
            Hide();
        }

        /// <summary>
        /// If too many unsuccesful login attemps, freeze screen
        /// </summary>
        private void Suspend()
        {
            _ct++;
            if (!validUser) //user was not found
            {
                lblMsg.Text = "No user named " + inUser;
                lblMsg.Enabled = true;
            }
            else if (!validPass) //user was found but password was wrong
            {
                lblMsg.Text = "Invalid Password.";
                lblMsg.Enabled = true;
            }

            txtPassword.Text = "";
            txtUsername.Text = "";
            if (_ct >= 3) //if 3 login attempts already, freeze form for desired amount of time
            {
                MessageBox.Show("No more attempts remaining");
                lblMsg.Text = "SUSPENDED";
                DateTime now = DateTime.Now;
                DateTime then = now.AddSeconds(5);
                this.Enabled = false;
                while (now < then) 
                {
                    now = DateTime.Now;
                }

                lblMsg.Text = "";
                this.Enabled = true;
                _ct = 0; //reset count
            }
        }

        /// <summary>
        /// Shut down program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            Close();
            Dispose();
        }
    }
}
