using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyleen_Project
{
    class Group
    {
        private string name;
        private List<Participant> participants;
        private double amountSaved;

        public Group() { }
        public Group (string groupName)
        {
            name = groupName;
            participants = new List<Participant>();
            amountSaved = 0;
        }

        public void addParticipant(Participant newParticipant) { participants.Add(newParticipant); }
        public Participant getParticipant(int participant) { return participants[participant]; }
        public string getName() { return name; }
        public int totalParticipants() { return participants.Count(); }
        public void setAmountSaved(double amount) { amountSaved = amount; }
        public void addSavings(double amount) { amountSaved += amount; }
        public double getAmountSaved() { return amountSaved; }
        
    }
}
