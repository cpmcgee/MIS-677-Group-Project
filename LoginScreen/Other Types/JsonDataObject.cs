using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class JsonDataObject
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string sex { get; set; }
        public string dateOfBirth { get; set; }
        public string backgroundStatus { get; set; }
        public bool assigned { get; set; } = false;
    }
}
