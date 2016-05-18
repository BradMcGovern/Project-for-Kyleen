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
        public double totalCost { get; set; }
        public int numberSeminars { get; set; }
        public List<Participant> participantList { get; set; }

        public Group() { }
        public Group (string groupName)
        {
            name = groupName;
            participantList = new List<Participant>();
            totalCost = 0;
            numberSeminars = 0;
        }
     
    }
}
