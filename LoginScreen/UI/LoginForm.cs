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
        //TODO:
        //- implement data sync and duplicate removal
        //- database design patterns


        bool validUser = false;
        bool validPass = false;
        bool validAcct = false;
        string inUser;
        string inPass;
        int _ct = 0;
        int _attempts = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChiltonDB dbase = ChiltonDB.GetInstance();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChiltonDB dbase = ChiltonDB.GetInstance();
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

            dbase.SubmitChanges(); //insert new login attempt record to database
            dbase.Connection.Close();
            validPass = false;
            validUser = false;
            validAcct = false;
            _attempts++;
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
            ChiltonDB dbase = ChiltonDB.GetInstance();
            try
            {
                Employee user = dbase.GetUser(username, password);
                if (user.GetType() == typeof(BuildTeamMember))
                {
                    LoginBuildTeam(user, dbase);
                }
                else if (user.GetType() == typeof(Supervisor))
                {
                    LoginSupervisor(user, dbase);
                }
                else if (user.GetType() == typeof(HRRep))
                {
                    LoginHRRep(user, dbase);
                }
                else if (user.GetType() == typeof(Manager))
                {
                    LoginManager(user, dbase);
                }
                else
                {
                    throw new Exception("Couldnt load form for user of role " + user.GetType().ToString());
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginBuildTeam(Employee user, ChiltonDB dbase)
        {
            List<EquipmentRequest> buildTeamRequests = dbase.GetBuildTeamData();
            uxBuildTeam form = new uxBuildTeam(user, buildTeamRequests);
            form.Show();
        }

        private void LoginSupervisor(Employee user, ChiltonDB dbase)
        {
            List<NewHire> hiresNoRequest;
            List<EquipmentRequest> supervisorRequests = dbase.GetSupervisorData(out hiresNoRequest);
            uxSupervisor form = new uxSupervisor(hiresNoRequest, supervisorRequests);
            form.Show();
        }

        private void LoginHRRep(Employee user, ChiltonDB dbase)
        {
            var ser = new JavaScriptSerializer();
            JsonDataObject[] jsonData = ser.Deserialize<JsonDataObject[]>(File.ReadAllText("C:\\Users\\Chris\\Desktop\\data.json"));
            List<EquipmentRequest> hrRequests = dbase.GetHRData();
            uxHRRep form = new uxHRRep(jsonData, hrRequests);
            form.Show();
        }

        private void LoginManager(Employee user, ChiltonDB dbase)
        {
            List<EquipmentRequest> mgrRequests = dbase.GetManagerData();
            uxSeniorManager form = new uxSeniorManager();
            form.Show();
        }

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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            Shutdown();
        }

        private void ShowError(string error)
        {
            MessageBox.Show(error);
        }

        public void Shutdown()
        {
            //form2.Close();
            //form2.Dispose();
            ChiltonDB.Close();
            Close();
            Dispose(); 
        }
    }
}
