using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public ChiltonDB dbase;
        Form2 form2;
        bool validUser = false;
        bool validPass = false;
        bool validAcct = false;
        string inUser;
        string inPass;
        int ct = 0;
        int _attempts = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connect to database
            try
            {
                dbase = new ChiltonDB("Data Source=10.135.85.168;User ID=Group2;Password=Grp22116@;");
            }
            catch
            {
                throw;
            }

            //instantiate dummy data
            _User user1 = new _User();
            user1.UserNum = 1;
            user1.Username = "johndoe";
            user1.Password = "password1";
            _User user2 = new _User();
            user2.UserNum = 2;
            user2.Username = "janesmith";
            user2.Password = "password2";

            try
            {
                dbase.ExecuteCommand("DROP TABLE _User");
                
            }
            catch { };
            try
            {
                dbase.ExecuteCommand("DROP TABLE _LoginAttempts");
            }
            catch { };
            dbase.ExecuteCommand("CREATE TABLE _User (UserNum int, Username varchar(20), Password varchar(20));");
            dbase.ExecuteCommand("CREATE TABLE _LoginAttempts (UserNum int, Username varchar(20), TimeStamp varchar(20), Success varchar(5), AttemptNum int);");

            dbase.Users.InsertOnSubmit(user1);
            dbase.Users.InsertOnSubmit(user2);

            dbase.SubmitChanges();

            form2 = new Form2(this); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            inUser = txtUsername.Text;
            inPass = txtPassword.Text;
            string inID = null;
            string pass = null; //stores password typed in by user

            foreach (_User u in dbase.Users)
            {
                string user = u.Username;
                inID = u.UserNum.ToString();
                if (user == inUser)
                {
                    validUser = true;
                    pass = u.Password;
                }
            }

            if (pass == inPass)
            {
                validPass = true;
            }
            if (validUser && validPass)
            {
                validAcct = true;
            }

            if (validAcct)
            {
                Authenticate();
            }
            else
            {
                Suspend();
            }

            _LoginAttempt la = new _LoginAttempt();

            la.UserNum = Convert.ToInt32(inID);
            la.Username = inUser;
            la.TimeStamp = DateTime.Now.ToString();
            la.Success = validAcct.ToString();
            la.AttemptNum = _attempts.ToString();

            dbase.LoginAttempts.InsertOnSubmit(la);
            dbase.SubmitChanges();

            validPass = false;
            validUser = false;
            validAcct = false;
            _attempts++;
        }

        public void Authenticate()
        {
            lblMsg.Text = "Success!";
            txtPassword.Text = "";
            txtUsername.Text = "";
            form2.Show();
            this.Hide();
        }

        public void Suspend()
        {
            ct++;
            if (!validUser)
            {
                lblMsg.Text = "No user named " + inUser;
                lblMsg.Enabled = true;
            }
            else if (!validPass)
            {
                lblMsg.Text = "Invalid Password.";
                lblMsg.Enabled = true;
            }

            

            txtPassword.Text = "";
            txtUsername.Text = "";
            if (ct >= 3)
            {
                MessageBox.Show("No more attempts remaining");
                DateTime now = DateTime.Now;
                DateTime then = now.AddSeconds(5);
                this.Enabled = false;
                while (now < then) //this can be changed to 2 hours for full implementation
                {
                    now = DateTime.Now;
                }

                lblMsg.Text = "";
                this.Enabled = true;
                ct = 0;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            Shutdown();
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error);
        }

        public void Shutdown()
        {
            form2.Close();
            form2.Dispose();
            Close();
            Dispose(); 
        }
    }
}
