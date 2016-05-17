using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyleen_Project
{
    class Participant
    {
        public string name { get; set; }
        public string group { get; set; }
        public double totalCost { get; set; }
        public double amountSaved { get; set; }
        public List<string> seminarList { get; set; }

        public Participant()
        { }

        public Participant(string partName, string partGroup)
        {
            name = partName;
            group = partGroup;
            seminarList = new List<string>();
            totalCost = 0;
            amountSaved = 0;
        }

    }
}
