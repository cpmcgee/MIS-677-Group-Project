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
        public int RequestNum { get; set; }
        public bool[] SoftwareOptions;
        public bool[] HardwareOptions;
        public int ApprovedBy { get; set; }
        public int Status { get; set; }
        public DateTime ApprovedOn { get; set; }
        public int RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public DateTime CompletedOn { get; set; }

        /* Equipement Request Status
         * 0 - Created
         * 1 - Pending Approval From Manager
         * 2 - Approved By Manager, Ready to send to build team
         * 3 - Denied by manager
         * 4 - Sent to build team
         * 5 - Built, pending build approval
         * 6 - Build approved, ready to be picked up
         * 7 - Picked up
         * */

        public EquipmentRequest(int newHireNum, int requestNum, int status, bool[] software, bool[] hardware, int supervisorNum, DateTime requestedOn, DateTime completedOn, int approvedBy, int requestedBy)
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
            RequestNum = requestNum;
            RequestedOn = DateTime.Now;
            RequestedBy = supervisorNum;
            Status = status;
        }

        public void UpdateRequest(bool[] hardware, bool[] software)
        {
            HardwareOptions = hardware;
            SoftwareOptions = software;
        }
    }
}
