using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        List<User> users;
        static DBServer database = new DBServer();
        Form2 form2;
        bool validUser = false;
        bool validPass = false;
        bool validAcct = false;
        string inUser;
        string inPass;
        User user1;
        User user2;
        User user3;
        User user4;
        User user5;
        int ct = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instantiate dummy data
            user1 = new User("Bob32", "Password");
            user2 = new User("JohnSmith", "1234");
            user3 = new User("bill12", "77uhde");
            user4 = new User("janedoe9", "trees");
            user5 = new User("Jack", "82y83ihf");

            users = new List<User>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);

            form2 = new Form2(this);
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            inUser = txtUsername.Text;
            inPass = txtPassword.Text;
            string pass = null; //stores password typed in by user

            foreach (User u in users)
            {
                if (u.Username == inUser)
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
            validPass = false;
            validUser = false;
            validAcct = false;
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

        private void QueryData()
        {
            ChiltonDB dbase = new ChiltonDB("Data Source=10.135.85.168;User ID=Group2;Password=Grp22116@;");
            IEnumerable<User> query = from u in dbase.Users
                                 where u.Username == "d"
                                 select u;

            User bob = new User();
            bob.UserID = "";
            bob.Password = "";
            bob.Username = "";

            dbase.Users.InsertOnSubmit(bob);
            dbase.SubmitChanges();
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
