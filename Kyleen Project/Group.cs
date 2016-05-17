using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyleen_Project
{
    class Group
    {
        public string name { get; set; }     
        public double amountSaved { get; set; }
        public List<Participant> participantList { get; set; }

        public Group() { }
        public Group (string groupName)
        {
            name = groupName;
            participantList = new List<Participant>();
            amountSaved = 0;
        }
     
    }
}
