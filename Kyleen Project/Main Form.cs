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

        //vaiables for client
        double clientNumberParticipants;
        double clientNumberSeminars;
        double clientTotalCost;
        //double clientSaved = 0;
        
        bool validAmountPaid;
        string seminarFile = @"seminar costs.csv";

        public frmMain()
        {
            InitializeComponent(); 
        } 

        private void form_OnLoad(object sender, EventArgs e)
        {
            //check to make sure the seminar costs file exists, and close application if it doesn't
            if (!File.Exists(seminarFile))
            {
                MessageBox.Show("File \"seminar costs.csv\" is missing, please replace or create it and restart application", "seminar costs file missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else //read seminar costs from file into dictionary
            {
                double seminarCost = 0;
                int lineIndex = -1;
          
                string[] fileLines = File.ReadAllLines(seminarFile);
                foreach (string line in fileLines)
                {
                    lineIndex += 1;
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
                                var saveToFile = MessageBox.Show("Would you like to change the file to this amount?", "Save to file?", MessageBoxButtons.YesNo);
                                if (saveToFile == DialogResult.Yes)
                                {
                                    fileLines[lineIndex] = values[0] + "," + seminarCost;
                                    File.WriteAllLines(seminarFile, fileLines);
                                }
                            }
                        }
                    }

                    seminarList.Add(values[0], seminarCost);

                } //end iterating through fileLines
            } //end read seminar costs
        } //end form_OnLoad()

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string name;
            string groupName;
            string seminar;
            int participantIndex;
            int groupIndex;
            int index; //for loop variable
            double seminarCost; 

            groupList.Clear();
            clientNumberParticipants = 0;
            clientNumberSeminars = 0;
            clientTotalCost = 0;

            //get information on particiapnts from file seleted by user
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";

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
                        groupIndex = -1;

                        for (index = 0; index < groupList.Count(); index++)
                        {
                            if (groupName == groupList[index].name)
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
                        for (index = 0; index < thisGroup.participantList.Count(); index++)
                        {
                            if (thisGroup.participantList[index].name == name)
                            {
                                participantIndex = index;
                                break;
                            }
                        }
                        if (participantIndex == -1)
                        {
                            Participant newParticipant = new Participant(name, groupName);
                            thisGroup.participantList.Add(newParticipant);
                            participantIndex = thisGroup.participantList.Count() - 1;
                        }

                        thisGroup.participantList[participantIndex].seminarList.Add(seminar);

                        if (!seminarList.TryGetValue(seminar, out seminarCost))
                        {
                            using (var inputForm = new frmInput("Seminar \"" + seminar + "\" not present in seminar cost file.", "Please enter a valid cost for this seminar"))
                            {
                                var inputResult = inputForm.ShowDialog();
                                if (inputResult == DialogResult.OK)
                                {
                                    seminarCost = inputForm.input;
                                    seminarList.Add(seminar, seminarCost);

                                    //present option to save this seminar to the file
                                    var saveToFile = MessageBox.Show("Would you like to save this seminar to the file?", "Save to file?", MessageBoxButtons.YesNo);
                                    if (saveToFile == DialogResult.Yes)
                                    {
                                        using (StreamWriter file = new StreamWriter(seminarFile, true))
                                        {
                                            file.WriteLine(seminar + "," + seminarCost.ToString());
                                        }
                                    }
                                }
                            }
                        }

                        thisGroup.participantList[participantIndex].totalCost += seminarCost;
                        
                           
                    } //end reading file and creating groups and particiapnts

                    //calculate totals for Group and Client
                    foreach (Group group in groupList)
                    {
                        foreach (Participant participant in group.participantList)
                        {
                            group.numberSeminars += participant.seminarList.Count();
                            group.totalCost += participant.totalCost;
                        }

                        clientNumberParticipants += group.participantList.Count();
                        clientNumberSeminars += group.numberSeminars;
                        clientTotalCost += group.totalCost;

                    }

                    //fill combo box with groups, and select the first group, which will fill the participant list
                    //select the first participant, which will fill the seminar list and the participant and group info boxes
                    //fill the client info boxes
                    cmbGroups.Items.Clear();
                    foreach (Group thisGroup in groupList)
                    {
                        cmbGroups.Items.Add(thisGroup.name);
                    }
                    cmbGroups.SelectedIndex = 0;
                    lstParticipants.SelectedIndex = 0;
                    lblClientParticipants.Text = clientNumberParticipants.ToString();
                    lblClientSeminars.Text = clientNumberSeminars.ToString();
                    lblClientTotalCost.Text = clientTotalCost.ToString("C2");

                } //end try
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file. Original error: " + ex.Message);
                }
            } //end file selection 



        } //end btnOpenFile_Click()

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstParticipants.Items.Clear();
            Group thisGroup = groupList[cmbGroups.SelectedIndex];
            for (int index = 0; index < thisGroup.participantList.Count(); index++)
            {
                lstParticipants.Items.Add(thisGroup.participantList[index].name);
            }

            lstParticipants.SelectedIndex = 0;
        }

        private void lstParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSeminars.Items.Clear();
            Group selectedGroup = groupList[cmbGroups.SelectedIndex];
            Participant selectedParticipant = selectedGroup.participantList[lstParticipants.SelectedIndex];

            for (int index = 0; index < selectedParticipant.seminarList.Count(); index++)
            {
                lstSeminars.Items.Add(selectedParticipant.seminarList[index]);
            }

            lblParticipantSeminars.Text = selectedParticipant.seminarList.Count.ToString();
            lblParticipantTotalCost.Text = selectedParticipant.totalCost.ToString("C2");
            lblGroupParticipants.Text = selectedGroup.participantList.Count().ToString();
            lblGroupSeminars.Text = selectedGroup.numberSeminars.ToString();
            lblGroupTotalCost.Text = selectedGroup.totalCost.ToString("C2");

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
                validAmountPaid = true;

                fillSavingsBoxes();
            } 
        } //end btnCalculate_Click()

        private void fillSavingsBoxes()
        {
            Group selectedGroup = groupList[cmbGroups.SelectedIndex];
            Participant selectedParticipant = selectedGroup.participantList[lstParticipants.SelectedIndex];
            double amountPaid;

            Double.TryParse(txtAmountPaid.Text, out amountPaid);

            lblParticipantSaved.Text = (selectedParticipant.totalCost - amountPaid).ToString("C2");
            lblGroupSaved.Text = (selectedGroup.totalCost - (amountPaid * selectedGroup.participantList.Count())).ToString("C2");
            lblClientSaved.Text = (clientTotalCost - (amountPaid * clientNumberParticipants)).ToString("C2");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    } //end class
} //end namespace
