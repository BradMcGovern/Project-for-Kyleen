using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyleen_Project
{
    public partial class frmInput : Form
    {
        public double input { get; set; }

        public frmInput(string message1, string message2)
        {
            InitializeComponent();
            lblMessage1.Text = message1;
            lblMessage2.Text = message2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double inputEntered;
            Double.TryParse(txtInput.Text, out inputEntered);

            if (inputEntered == 0)
            {
                MessageBox.Show("Please enter a valid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.input = inputEntered;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
