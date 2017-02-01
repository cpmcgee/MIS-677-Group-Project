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
        public IChiltonDB dbase;
        Form2 form2;
        bool validUser = false;
        bool validPass = false;
        bool validAcct = false;
        string inUser;
        string inPass;
        int _ct = 0;
        int _attempts = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //For portability and debugging purposes, this load method contains (un)commented logic for erasing and setting up the database on each run

            //instantiate dummy data
            User user1 = new User();
            user1.UserID = 1;
            user1.Username = "johndoe";
            user1.Password = "password1";
            User user2 = new User();
            user2.UserID = 2;
            user2.Username = "janesmith";
            user2.Password = "password2";
            //connect to database
            try
            {
                //IChiltonDB : DBClassesDataContext : DataContext is a class used to initiate a connection to a database with use for Linq to SQL statements implementing IQueryable<T>()

                //dbase = new IChiltonDB("Data Source=10.135.85.168;User ID=Group2;Password=Grp22116@;");
                dbase = new IChiltonDB("Data Source = (localdb)\\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");


                //dbase.ExecuteCommand("DROP TABLE Users;");
                //dbase.ExecuteCommand("DROP TABLE LoginAttempts;");
                //dbase.ExecuteCommand("DROP TABLE _Users;");
                //dbase.ExecuteCommand("DROP TABLE _LoginAttempts;");

                //dbase.ExecuteCommand("CREATE TABLE Users (UserID int, Username varchar(20), Password varchar(20), Name varchar(30));");
                //dbase.ExecuteCommand("CREATE TABLE LoginAttempts (UserID int, Username varchar(20), TimeStamp varchar(20), Success varchar(10), AttemptNum int);");



                //dbase.ExecuteCommand("DELETE FROM Users;");
                //dbase.ExecuteCommand("DELETE FROM LoginAttempts;");
                dbase.Users.InsertOnSubmit(user1);
                dbase.Users.InsertOnSubmit(user2);

                dbase.SubmitChanges();
                
                form2 = new Form2(this);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            inUser = txtUsername.Text;
            inPass = txtPassword.Text;
            string inID = null;
            string pass = null;

            if (inUser.Contains("\"") || inPass.Contains("\""))
            {
                MessageBox.Show("Username and Password field cannot contain SQL statements.");
                _ct++;
            }
            else
            {
                foreach (User u in dbase.Users) //loop through database table to check for user
                {
                    string user = u.Username;
                    inID = u.UserID.ToString();
                    if (user == inUser)
                    {
                        validUser = true;
                        pass = u.Password; //save users actual password
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
                    Authenticate(); //let user in
                }
                else
                {
                    Suspend(); //reset form, lock user out if 3 failed attempts
                }

                LoginAttempt la = new LoginAttempt //create new login attempt object (based on current state) to add to database
                {
                    UserID = Convert.ToInt32(inID),
                    Username = inUser,
                    TimeStamp = DateTime.Now.ToString("MM/dd/yy HH:mm:ss"),
                    Success = validAcct.ToString(),
                    AttemptNum = _attempts,
                };

                dbase.LoginAttempts.InsertOnSubmit(la);
                dbase.SubmitChanges(); //insert new login attempt record to database

                validPass = false;
                validUser = false;
                validAcct = false;
                _attempts++;
            }
        }

        //accept user, load form2
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
                DateTime now = DateTime.Now;
                DateTime then = now.AddSeconds(5);
                this.Enabled = false;
                while (now < then) //this can be changed to 2 hours for full implementation
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

        public void ShowError(string error)
        {
            MessageBox.Show(error);
        }

        public void Shutdown()
        {
            //form2.Close();
            //form2.Dispose();
            Close();
            Dispose(); 
        }
    }
}
