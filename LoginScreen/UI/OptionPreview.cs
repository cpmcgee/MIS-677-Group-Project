﻿using System;
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
    public partial class OptionPreview : Form
    {
        Dictionary<int, string> hardwareOptions = new Dictionary<int, string>();
        Dictionary<int, string> softwareOptions = new Dictionary<int, string>();

        public OptionPreview(EquipmentRequest req)
        {
            InitializeComponent();

            hardwareOptions.Add(0, "Laptop");
            hardwareOptions.Add(1, "Desktop");
            hardwareOptions.Add(2, "Monitor");
            hardwareOptions.Add(3, "VGA Cable");
            hardwareOptions.Add(4, "HDMI Cable");
            hardwareOptions.Add(5, "DVI Cable");
            hardwareOptions.Add(6, "Wired Mouse");
            hardwareOptions.Add(7, "Wireless Mouse");
            hardwareOptions.Add(8, "Keyboard");
            hardwareOptions.Add(9, "Ergonomic Keyboard");
            hardwareOptions.Add(10, "Comfort Foot Mat");
            hardwareOptions.Add(11, "Telephone");
            hardwareOptions.Add(12, "Laptop Docking Station");

            softwareOptions.Add(0, "Office 2017 Suite");
            softwareOptions.Add(1, "Project Manager");
            softwareOptions.Add(2, "Prophet DBMS");
            softwareOptions.Add(3, "Seagull Design Pro");
            softwareOptions.Add(4, "Seagull Design Lite");
            softwareOptions.Add(5, "Visual Workroom");
            softwareOptions.Add(6, "GET Version Control");
            softwareOptions.Add(7, "Citrix Reciever");
            softwareOptions.Add(8, "Citrix Dev Console");
            
            for (int i = 0; i < req.SoftwareOptions.Length; i++)
            {
                if (req.SoftwareOptions[i])
                {
                    lstSoftware.Items.Add(softwareOptions[i]);
                }
            }

            for (int i = 0; i < req.HardwareOptions.Length; i++)
            {
                if (req.HardwareOptions[i])
                {
                    lstHardware.Items.Add(hardwareOptions[i]);
                }
            }
        }
    }
}
