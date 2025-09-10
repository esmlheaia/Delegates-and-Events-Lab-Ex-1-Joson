namespace AccountRegistration
{
    partial class FrmConfirm
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
            this.labelstudentno = new System.Windows.Forms.Label();
            this.labelprogram = new System.Windows.Forms.Label();
            this.labellastname = new System.Windows.Forms.Label();
            this.labelage = new System.Windows.Forms.Label();
            this.labelcontactnum = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelstudentno
            // 
            this.labelstudentno.AutoSize = true;
            this.labelstudentno.Location = new System.Drawing.Point(3, 10);
            this.labelstudentno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstudentno.Name = "labelstudentno";
            this.labelstudentno.Size = new System.Drawing.Size(74, 15);
            this.labelstudentno.TabIndex = 0;
            this.labelstudentno.Text = "Student No.:";
            // 
            // labelprogram
            // 
            this.labelprogram.AutoSize = true;
            this.labelprogram.Location = new System.Drawing.Point(3, 65);
            this.labelprogram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelprogram.Name = "labelprogram";
            this.labelprogram.Size = new System.Drawing.Size(58, 15);
            this.labelprogram.TabIndex = 1;
            this.labelprogram.Text = "Program:";
            // 
            // labellastname
            // 
            this.labellastname.AutoSize = true;
            this.labellastname.Location = new System.Drawing.Point(3, 37);
            this.labellastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labellastname.Name = "labellastname";
            this.labellastname.Size = new System.Drawing.Size(44, 15);
            this.labellastname.TabIndex = 2;
            this.labellastname.Text = "Name:";
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.Location = new System.Drawing.Point(3, 90);
            this.labelage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(31, 15);
            this.labelage.TabIndex = 5;
            this.labelage.Text = "Age:";
            // 
            // labelcontactnum
            // 
            this.labelcontactnum.AutoSize = true;
            this.labelcontactnum.Location = new System.Drawing.Point(4, 198);
            this.labelcontactnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcontactnum.Name = "labelcontactnum";
            this.labelcontactnum.Size = new System.Drawing.Size(73, 15);
            this.labelcontactnum.TabIndex = 6;
            this.labelcontactnum.Text = "Contact No.:";
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.Location = new System.Drawing.Point(3, 117);
            this.labeladdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(57, 15);
            this.labeladdress.TabIndex = 7;
            this.labeladdress.Text = "Address: ";
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(109, 245);
            this.bSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(88, 26);
            this.bSubmit.TabIndex = 8;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Birthday:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gender:";
            // 
            // FrmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(333, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.labelcontactnum);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.labellastname);
            this.Controls.Add(this.labelprogram);
            this.Controls.Add(this.labelstudentno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConfirm";
            this.Text = "FrmConfirm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConfirm_FormClosing);
            this.Load += new System.EventHandler(this.FrmConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelstudentno;
        private System.Windows.Forms.Label labelprogram;
        private System.Windows.Forms.Label labellastname;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.Label labelcontactnum;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}