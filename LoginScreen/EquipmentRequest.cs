using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class EquipmentRequest
    {
        public int NewHireNum { get; set; }
        public bool IsApproved { get; set; }
        public bool IsBuilt { get; set; }
        public bool[] SoftwareOptions = new bool[9];
        public bool[] HardwareOptions = new bool[13];
        public Employee ApprovedBy { get; set; }
        public DateTime ApprovedOn { get; set; }
        public int RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public DateTime CompletedOn { get; set; }
        public bool IsDelivered { get; set; }

        public EquipmentRequest(int newHireNum, bool[] software, bool[] hardware, int supervisorNum)
        {
            NewHireNum = newHireNum;
            /*SOFTWARE OPTIONS INDEXING
             * 0 - Office 2017 Suite
             * 1 - Project Manager
             * 2 - Prophet Database Management Software
             * 3 - Seagull Design Suite Pro
             * 4 - Seagull Design Suite Lite
             * 5 - Visual Workroom Pro
             * 6 - GET Version Control
             * 7 - Citrix Receiver
             * 8 - Citrix Developer Console
             * * * * * * * * * * * * * * * */
            SoftwareOptions = software;

            /* HARDWARE OPTIONS INDEXING
             * 0 - Laptop
             * 1 - Desktop
             * 2 - Monitor
             * 3 - VGA Cable
             * 4 - HDMI Cable
             * 5 - DVI Cable
             * 6 - Wired Mouse
             * 7 - Wireless Mouse
             * 8 - Keyboard
             * 9 - Ergonomic Keyboard
             * 10 - Comfort Foot Mat
             * 11 - Telephone
             * 12 - Laptop Docking Station
             * * * * * * * * * * * * * * * */
            HardwareOptions = hardware;

            RequestedOn = DateTime.Now;
            RequestedBy = supervisorNum;
        }

        public void Approve(Employee approvedBy)
        {
            IsApproved = true;
            ApprovedOn = DateTime.Now;
        }

        public void Complete()
        {
            CompletedOn = DateTime.Now;
            IsBuilt = true;
        }

        public void UpdateRequest(bool[] hardware, bool[] software)
        {
            HardwareOptions = hardware;
            SoftwareOptions = software;
        }
    }
}
