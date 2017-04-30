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
    public partial class uxBuildTeam : Form
    {
        Employee User;
        List<EquipmentRequest> requests;
        public uxBuildTeam(Employee user, List<EquipmentRequest> requests)
        {
            this.requests = requests;
            User = user;
            InitializeComponent();
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            //write to completed on field
        }
    }
}
