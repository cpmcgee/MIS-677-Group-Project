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
        //Form1 form1 = new Form1();
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
            foreach (_LoginAttempt la in dbase.LoginAttempts)
            {
                results.Append(la.AttemptNum.ToString() + " " + la.Username.ToString() + " " + la.Success.ToString() + " " + la.TimeStamp.ToString() + "\n");
            }
            MessageBox.Show(results.ToString());
        }
    }
}
