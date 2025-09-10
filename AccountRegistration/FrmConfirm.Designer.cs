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
            this.labelfirstname = new System.Windows.Forms.Label();
            this.labelage = new System.Windows.Forms.Label();
            this.labelcontactnum = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.labelbirthday = new System.Windows.Forms.Label();
            this.labelgender = new System.Windows.Forms.Label();
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
            // labelfirstname
            // 
            this.labelfirstname.AutoSize = true;
            this.labelfirstname.Location = new System.Drawing.Point(3, 37);
            this.labelfirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfirstname.Name = "labelfirstname";
            this.labelfirstname.Size = new System.Drawing.Size(44, 15);
            this.labelfirstname.TabIndex = 2;
            this.labelfirstname.Text = "Name:";
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
            this.bSubmit.Location = new System.Drawing.Point(128, 244);
            this.bSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(88, 26);
            this.bSubmit.TabIndex = 8;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // labelbirthday
            // 
            this.labelbirthday.AutoSize = true;
            this.labelbirthday.Location = new System.Drawing.Point(3, 146);
            this.labelbirthday.Name = "labelbirthday";
            this.labelbirthday.Size = new System.Drawing.Size(54, 15);
            this.labelbirthday.TabIndex = 9;
            this.labelbirthday.Text = "Birthday:";
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Location = new System.Drawing.Point(3, 172);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(51, 15);
            this.labelgender.TabIndex = 10;
            this.labelgender.Text = "Gender:";
            // 
            // FrmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(333, 303);
            this.Controls.Add(this.labelgender);
            this.Controls.Add(this.labelbirthday);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.labelcontactnum);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.labelfirstname);
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
        private System.Windows.Forms.Label labelfirstname;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.Label labelcontactnum;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Label labelbirthday;
        private System.Windows.Forms.Label labelgender;
    }
}