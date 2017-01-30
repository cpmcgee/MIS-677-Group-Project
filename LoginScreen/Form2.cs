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
        ChiltonDB dbase;

        public Form2(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm as Form1;
            dbase = opener.dbase;
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
            StringBuilder results = new StringBuilder();
            foreach (LoginAttempt la in dbase.LoginAttempts)
            {
                bool success = la.Success == "True";
                string entry = "";
                if (success)
                    entry = String.Format("{0} - User: {1} with ID: {2} successfully logged in at {3}", la.AttemptNum, la.Username.ToString(), la.UserID.ToString(), la.TimeStamp.ToString() + "\n");
                else
                    entry = String.Format("{0} - User: {1} with ID: {2} failed to log in at {3}", la.AttemptNum, la.Username.ToString(), la.UserID.ToString(), la.TimeStamp.ToString() + "\n");
                results.Append(entry);
            }
            MessageBox.Show(results.ToString());
        }
    }
}
