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
        private Employee User { get; set; }

        public uxBuildTeam(Employee user, List<EquipmentRequest> requests)
        {
            User = user;
            InitializeComponent();
        }
    }
}
