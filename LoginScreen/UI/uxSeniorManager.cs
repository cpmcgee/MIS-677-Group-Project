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
    public partial class uxSeniorManager : Form
    {
        Employee User;
        List<NewHire> hires;
        public uxSeniorManager(Employee user, List<NewHire> hires)
        {
            this.hires = hires;
            User = user;
            InitializeComponent();
        }

        private void uxApprove_Click(object sender, EventArgs e)
        {
            //write to ApprovedOn field
        }
    }
}
