using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    
    public partial class Form2 : Form
    {
        Form1 opener;
        Form3 form3;

        public Form2(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm as Form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            opener.Shutdown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChiltonDB dbase = new ChiltonDB(Program.ConnectionString);
            StringBuilder results = new StringBuilder(); //create stringbuilder 
            foreach (LoginAttempt la in dbase.LoginAttempts) //loop through database of login attempts and add each line to the stringbuilder
            {
                bool success = la.Success == "True";
                string entry = "";
                if (success)
                    entry = String.Format("{0} - User: {1} with ID: {2} successfully logged in at {3}", la.AttemptNum, la.Username.ToString(), la.UserID.ToString(), la.TimeStamp.ToString() + "\n");
                else
                    entry = String.Format("{0} - User: {1} with ID: {2} failed to log in at {3}", la.AttemptNum, la.Username.ToString(), la.UserID.ToString(), la.TimeStamp.ToString() + "\n");
                results.Append(entry);
            }
            MessageBox.Show(results.ToString()); //show stringbuilder full of log lines in a messagebox
            dbase.Connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3 = new Form3(this);
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChiltonDB dbase = new ChiltonDB(Program.ConnectionString);
            StringBuilder results = new StringBuilder(); //create stringbuilder 
            foreach (User u in dbase.Users) //loop through database of login attempts and add each line to the stringbuilder
            {
                string entry = u.Username + "\n";
                results.Append(entry);
            }
            MessageBox.Show(results.ToString()); //show stringbuilder full of log lines in a messagebox
            dbase.Connection.Close();
        }
    }
}
