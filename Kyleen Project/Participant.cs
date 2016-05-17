using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyleen_Project
{
    class Participant
    {
        private string name;
        private string group;
        private List<string> seminarList;
        private double totalCost;
        private double amountSaved;

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

        public string getName() { return name; }
        public string getGroup() { return group;}
        public void addSeminar(string seminar) { seminarList.Add(seminar); }
        public string getSeminar(int seminar) { return seminarList[seminar]; }
        public int totalSeminars() {  return seminarList.Count(); }
        public void setTotalCost(int amount) { totalCost = amount; }
        public void addCost(double amount) { totalCost += amount; }
        public double getTotalCost() { return totalCost; }
        public void setAmountSaved(double amount) { amountSaved = amount; }
        public void addSavings(double amount) { amountSaved += amount; }
        public double getAmountSaved() { return amountSaved; }

    }
}
