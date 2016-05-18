namespace Kyleen_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.lstParticipants = new System.Windows.Forms.ListBox();
            this.lblParticipantTotalCost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblParticipantSaved = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblParticipantSeminars = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.lstSeminars = new System.Windows.Forms.ListBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGroupSaved = new System.Windows.Forms.Label();
            this.lblGroupParticipants = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGroupSeminars = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblGroupTotalCost = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblClientSaved = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblClientParticipants = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblClientSeminars = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblClientTotalCost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(828, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstParticipants
            // 
            this.lstParticipants.FormattingEnabled = true;
            this.lstParticipants.Location = new System.Drawing.Point(27, 147);
            this.lstParticipants.Name = "lstParticipants";
            this.lstParticipants.Size = new System.Drawing.Size(129, 277);
            this.lstParticipants.TabIndex = 8;
            this.lstParticipants.SelectedIndexChanged += new System.EventHandler(this.lstParticipants_SelectedIndexChanged);
            // 
            // lblParticipantTotalCost
            // 
            this.lblParticipantTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParticipantTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipantTotalCost.Location = new System.Drawing.Point(10, 196);
            this.lblParticipantTotalCost.Name = "lblParticipantTotalCost";
            this.lblParticipantTotalCost.Size = new System.Drawing.Size(100, 26);
            this.lblParticipantTotalCost.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblParticipantSaved);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblParticipantSeminars);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblParticipantTotalCost);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(368, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 296);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total savings";
            // 
            // lblParticipantSaved
            // 
            this.lblParticipantSaved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParticipantSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipantSaved.Location = new System.Drawing.Point(10, 260);
            this.lblParticipantSaved.Name = "lblParticipantSaved";
            this.lblParticipantSaved.Size = new System.Drawing.Size(100, 26);
            this.lblParticipantSaved.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "registration cost";
            // 
            // lblParticipantSeminars
            // 
            this.lblParticipantSeminars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParticipantSeminars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipantSeminars.Location = new System.Drawing.Point(10, 114);
            this.lblParticipantSeminars.Name = "lblParticipantSeminars";
            this.lblParticipantSeminars.Size = new System.Drawing.Size(100, 26);
            this.lblParticipantSeminars.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total individual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total # of seminars";
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(27, 95);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(208, 21);
            this.cmbGroups.TabIndex = 19;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // lstSeminars
            // 
            this.lstSeminars.FormattingEnabled = true;
            this.lstSeminars.Location = new System.Drawing.Point(162, 147);
            this.lstSeminars.Name = "lstSeminars";
            this.lstSeminars.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSeminars.Size = new System.Drawing.Size(185, 277);
            this.lstSeminars.TabIndex = 20;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(368, 385);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(95, 39);
            this.btnOpenFile.TabIndex = 22;
            this.btnOpenFile.Text = "&Load File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "&Group";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "&Participants";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(158, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "&Seminars Taken";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(481, 385);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 39);
            this.btnCalculate.TabIndex = 27;
            this.btnCalculate.Text = "&Calculate Savings";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "&Amount Paid";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(251, 90);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(96, 26);
            this.txtAmountPaid.TabIndex = 29;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblGroupSaved);
            this.groupBox3.Controls.Add(this.lblGroupParticipants);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblGroupSeminars);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblGroupTotalCost);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(547, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 296);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Group";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Total # of participants";
            // 
            // lblGroupSaved
            // 
            this.lblGroupSaved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGroupSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupSaved.Location = new System.Drawing.Point(10, 257);
            this.lblGroupSaved.Name = "lblGroupSaved";
            this.lblGroupSaved.Size = new System.Drawing.Size(100, 26);
            this.lblGroupSaved.TabIndex = 30;
            // 
            // lblGroupParticipants
            // 
            this.lblGroupParticipants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGroupParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupParticipants.Location = new System.Drawing.Point(10, 51);
            this.lblGroupParticipants.Name = "lblGroupParticipants";
            this.lblGroupParticipants.Size = new System.Drawing.Size(100, 26);
            this.lblGroupParticipants.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total savings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "registration cost";
            // 
            // lblGroupSeminars
            // 
            this.lblGroupSeminars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGroupSeminars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupSeminars.Location = new System.Drawing.Point(10, 111);
            this.lblGroupSeminars.Name = "lblGroupSeminars";
            this.lblGroupSeminars.Size = new System.Drawing.Size(100, 26);
            this.lblGroupSeminars.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "Total individual";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "Total # of seminars";
            // 
            // lblGroupTotalCost
            // 
            this.lblGroupTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGroupTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupTotalCost.Location = new System.Drawing.Point(10, 193);
            this.lblGroupTotalCost.Name = "lblGroupTotalCost";
            this.lblGroupTotalCost.Size = new System.Drawing.Size(100, 26);
            this.lblGroupTotalCost.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblClientSaved);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lblClientParticipants);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.lblClientSeminars);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.lblClientTotalCost);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(728, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 296);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Client";
            // 
            // lblClientSaved
            // 
            this.lblClientSaved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientSaved.Location = new System.Drawing.Point(10, 260);
            this.lblClientSaved.Name = "lblClientSaved";
            this.lblClientSaved.Size = new System.Drawing.Size(100, 26);
            this.lblClientSaved.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(161, 20);
            this.label19.TabIndex = 31;
            this.label19.Text = "Total # of participants";
            // 
            // lblClientParticipants
            // 
            this.lblClientParticipants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientParticipants.Location = new System.Drawing.Point(10, 51);
            this.lblClientParticipants.Name = "lblClientParticipants";
            this.lblClientParticipants.Size = new System.Drawing.Size(100, 26);
            this.lblClientParticipants.TabIndex = 28;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 237);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 20);
            this.label22.TabIndex = 29;
            this.label22.Text = "Total savings";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 173);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 20);
            this.label23.TabIndex = 27;
            this.label23.Text = "registration cost";
            // 
            // lblClientSeminars
            // 
            this.lblClientSeminars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientSeminars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientSeminars.Location = new System.Drawing.Point(10, 111);
            this.lblClientSeminars.Name = "lblClientSeminars";
            this.lblClientSeminars.Size = new System.Drawing.Size(100, 26);
            this.lblClientSeminars.TabIndex = 26;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 153);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(112, 20);
            this.label25.TabIndex = 25;
            this.label25.Text = "Total individual";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(6, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(143, 20);
            this.label26.TabIndex = 24;
            this.label26.Text = "Total # of seminars";
            // 
            // lblClientTotalCost
            // 
            this.lblClientTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientTotalCost.Location = new System.Drawing.Point(10, 193);
            this.lblClientTotalCost.Name = "lblClientTotalCost";
            this.lblClientTotalCost.Size = new System.Drawing.Size(100, 26);
            this.lblClientTotalCost.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(929, 444);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lstSeminars);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstParticipants);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.form_OnLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstParticipants;
        private System.Windows.Forms.Label lblParticipantTotalCost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.ListBox lstSeminars;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblParticipantSeminars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblParticipantSaved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblGroupSaved;
        private System.Windows.Forms.Label lblGroupParticipants;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGroupSeminars;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblGroupTotalCost;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblClientSaved;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblClientParticipants;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblClientSeminars;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblClientTotalCost;
    }
}

