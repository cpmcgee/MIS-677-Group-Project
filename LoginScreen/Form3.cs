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
    public partial class Form3 : Form
    {
        Form2 opener;
        public Form3(Form2 parentForm)
        {
            InitializeComponent();
            opener = parentForm as Form2;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser(txtUsername.Text, txtPassword.Text);
        }

        public void AddUser(string username, string password)
        {
            ChiltonDB dbase = ChiltonDB.GetInstance();
            User newUser = new User
            {
                Password = password,
                Username = username,
            };

            dbase.Users.InsertOnSubmit(newUser);
            dbase.SubmitChanges();
            dbase.Connection.Close();
        }
    }
}
