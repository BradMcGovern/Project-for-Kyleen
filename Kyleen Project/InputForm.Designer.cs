namespace Kyleen_Project
{
    partial class frmInput
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.lblSeminar = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(43, 162);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(43, 209);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage1.Location = new System.Drawing.Point(40, 42);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(17, 16);
            this.lblMessage1.TabIndex = 2;
            this.lblMessage1.Text = "...";
            // 
            // lblSeminar
            // 
            this.lblSeminar.AutoSize = true;
            this.lblSeminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeminar.Location = new System.Drawing.Point(40, 80);
            this.lblSeminar.Name = "lblSeminar";
            this.lblSeminar.Size = new System.Drawing.Size(17, 16);
            this.lblSeminar.TabIndex = 3;
            this.lblSeminar.Text = "...";
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage2.Location = new System.Drawing.Point(40, 115);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(17, 16);
            this.lblMessage2.TabIndex = 4;
            this.lblMessage2.Text = "...";
            // 
            // frmInput
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(629, 293);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblSeminar);
            this.Controls.Add(this.lblMessage1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtInput);
            this.Name = "frmInput";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Label lblSeminar;
        private System.Windows.Forms.Label lblMessage2;
    }
}