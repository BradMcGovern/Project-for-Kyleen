using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyleen_Project
{
    public partial class frmMain : Form
    {
        List<Group> groupList = new List<Group>();
        Dictionary<string, double> seminarList = new Dictionary<string, double>();

        double clientSaved = 0;
        bool validAmountPaid;

        public frmMain()
        {
            InitializeComponent();

            double seminarCost = 0;

            //read seminar costs from file into dictionary
            using (StreamReader sr = new StreamReader(@"..\..\seminar costs.csv"))
            {
               while (sr.Peek() >= 0)
               {
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                    Double.TryParse(values[1], out seminarCost);

                    if (seminarCost == 0)
                    {
                        using (var form = new frmInput("Cost for seminar \"" + values[0] + "\" is not a valid decimal number.", "Please enter a valid cost for this seminar"))
                        {
                            var result = form.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                seminarCost = form.input;
                            }
                        }
                    }

                    seminarList.Add(values[0], seminarCost);
                }

            } //end read seminar costs

        } //end frmMain()

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bthOpenFile_Click(object sender, EventArgs e)
        {
            string name;
            string groupName;
            string seminar;
            int participantIndex;
            int groupIndex;
            int index; //for loop variable
            double seminarCost; 

            groupList.Clear();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    while (sr.Peek() >= 0)
                    {
                        var line = sr.ReadLine();
                        var values = line.Split(',');
                        name = values[0] + ", " + values[1];
                        groupName = values[2];
                        seminar = values[3];


                        //search to see if group is already in list
                        //and if not, add it
                        //and in eiter case add participant
                        groupIndex = -1;

                        for (index = 0; index < groupList.Count(); index++)
                        {
                            if (groupName == groupList[index].getName())
                            {
                                groupIndex = index;
                                break;
                            }
                        }

                        if (groupIndex == -1)
                        {
                            Group newGroup = new Group(groupName);
                            groupList.Add(newGroup);
                            groupIndex = groupList.Count() - 1;
                        }

                        //search to see if particpant already exists in group;
                        //if not, create new participant
                        //if so, add seminar and cost to that participant
                        Group thisGroup = groupList[groupIndex];
                        participantIndex = -1;
                        for (index = 0; index < thisGroup.totalParticipants(); index++)
                        {
                            if (thisGroup.getParticipant(index).getName() == name)
                            {
                                participantIndex = index;
                                break;
                            }
                        }
                        if (participantIndex == -1)
                        {
                            Participant newParticipant = new Participant(name, groupName);
                            thisGroup.addParticipant(newParticipant);
                            participantIndex = thisGroup.totalParticipants() - 1;
                        }//end check participants

                        thisGroup.getParticipant(participantIndex).addSeminar(seminar);

                        if (seminarList.TryGetValue(seminar, out seminarCost))
                        {
                            thisGroup.getParticipant(participantIndex).addCost(seminarCost);
                        }
                        else
                        {
                            using (var form = new frmInput("Seminar \"" + seminar + "\" not present in seminar cost file.", "Please enter a valid cost for this seminar"))
                            {
                                var result = form.ShowDialog();
                                if (result == DialogResult.OK)
                                {
                                    thisGroup.getParticipant(participantIndex).addCost(form.input);
                                }
                            }
                            
                        }
                        
                        
                    } //end read file

                    cmbGroups.Items.Clear();
                    foreach (Group thisGroup in groupList)
                    {
                        cmbGroups.Items.Add(thisGroup.getName());
                    }
                    cmbGroups.SelectedIndex = 0;
                    //cmbGroups_SelectedIndexChanged(sender, e);
                    lstParticipants.SelectedIndex = 0;
                    //lstParticipants_SelectedIndexChanged(sender, e);

                } //end try
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. Original error: " + ex.Message);
                }
            } //end open dialog

        } //end btnOpenFile_Click()

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstParticipants.Items.Clear();
            Group thisGroup = groupList[cmbGroups.SelectedIndex];
            for (int index = 0; index < thisGroup.totalParticipants(); index++)
            {
                lstParticipants.Items.Add(thisGroup.getParticipant(index).getName());
            }

            lstParticipants.SelectedIndex = 0;
        }

        private void lstParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSeminars.Items.Clear();
            Participant thisParticipant = groupList[cmbGroups.SelectedIndex].getParticipant(lstParticipants.SelectedIndex);
            for (int index = 0; index < thisParticipant.totalSeminars(); index++)
            {
                lstSeminars.Items.Add(thisParticipant.getSeminar(index));
            }

            lblNumSeminars.Text = thisParticipant.totalSeminars().ToString();
            lblTotalCost.Text = thisParticipant.getTotalCost().ToString("C2");
            if (validAmountPaid)
                fillSavingsBoxes();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double amountPaid;
            validAmountPaid = false;

            lblParticipantSaved.Text = "";
            lblGroupSaved.Text = "";
            lblClientSaved.Text = "";

            double.TryParse(txtAmountPaid.Text, out amountPaid);

            if (groupList.Count() == 0)
            {
                MessageBox.Show("Please load a file first", "No File Loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (amountPaid == 0)
            {
                MessageBox.Show("Please enter a valid amount in Amount Paid", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int group;
                int participant;

                validAmountPaid = true;
                clientSaved = 0;
                txtAmountPaid.Text = amountPaid.ToString("C2");
                
                for (group = 0; group < groupList.Count(); group++)
                {
                    Group thisGroup = groupList[group];
                    thisGroup.setAmountSaved(0);
                    for (participant = 0; participant < thisGroup.totalParticipants(); participant++)
                    {
                        Participant thisParticipant = thisGroup.getParticipant(participant);
                        double amountSaved = thisParticipant.getTotalCost() - amountPaid;
                        thisParticipant.setAmountSaved(amountSaved);
                        thisGroup.addSavings(amountSaved);
                        
                    }
                    clientSaved += thisGroup.getAmountSaved();
                    
                }

                fillSavingsBoxes();

            } //end actions for valid cost given


        } //end btnCalculate_Click()

        private void fillSavingsBoxes()
        {
            Group selectedGroup = groupList[cmbGroups.SelectedIndex];
            Participant selectedParticipant = selectedGroup.getParticipant(lstParticipants.SelectedIndex);

            lblParticipantSaved.Text = selectedParticipant.getAmountSaved().ToString("C2");
            lblGroupSaved.Text = selectedGroup.getAmountSaved().ToString("C2");
            lblClientSaved.Text = clientSaved.ToString("C2");
        }

    } //end class
} //end namespace
