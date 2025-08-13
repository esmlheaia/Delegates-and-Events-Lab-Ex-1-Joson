namespace AccountRegistration
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtstudentno = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtcontactno = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.cbprogram = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Next = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Middle Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact No.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address";
            // 
            // txtstudentno
            // 
            this.txtstudentno.Location = new System.Drawing.Point(15, 24);
            this.txtstudentno.Name = "txtstudentno";
            this.txtstudentno.Size = new System.Drawing.Size(128, 20);
            this.txtstudentno.TabIndex = 8;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(15, 63);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(128, 20);
            this.txtlastname.TabIndex = 9;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(149, 63);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(131, 20);
            this.txtfirstname.TabIndex = 10;
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.Location = new System.Drawing.Point(285, 63);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(131, 20);
            this.txtmiddlename.TabIndex = 11;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(15, 102);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(128, 20);
            this.txtage.TabIndex = 12;
            // 
            // txtcontactno
            // 
            this.txtcontactno.Location = new System.Drawing.Point(149, 102);
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(131, 20);
            this.txtcontactno.TabIndex = 13;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(15, 142);
            this.txtaddress.MaximumSize = new System.Drawing.Size(200, 150);
            this.txtaddress.MinimumSize = new System.Drawing.Size(400, 170);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(400, 170);
            this.txtaddress.TabIndex = 17;
            // 
            // cbprogram
            // 
            this.cbprogram.FormattingEnabled = true;
            this.cbprogram.Items.AddRange(new object[] {
            "Bachelor of Science in Computer Science",
            "Bachelor of Science in Information Technology",
            "Bachelor of Science in Tourism Management",
            "Bachelor of Science in Business Administration",
            "Bachelor of Science in Psychology",
            "Bachelor of Science in Multimedia Arts",
            "Bachelor of Science in Secondary Education",
            "Bachelor of Science in Hospitality Management",
            "Bachelor of Science in Accountancy",
            "Bachelor of Science in Civil Engineering",
            "Bachelor of Science in Architecture",
            "Bachelor of Science in Electronics Engineering",
            "Bachelor of Science in Electrical Engineering",
            "Bachelor of Science in Mechanical Engineering",
            "Bachelor of Science in Chemical Engineering",
            "Bachelor of Science in Agriculture",
            "Bachelor of Science in Fisheries",
            "Bachelor of Science in Criminology",
            "Bachelor of Science in Agriculture and Biosystems Engineering",
            "Bachelor of Science in Food Technology",
            "Bachelor of Science in Environmental Science",
            "Bachelor of Science in Geology",
            "Bachelor of Science in Marine Biology",
            "Bachelor of Science in Nursing",
            "Bachelor of Science in Pharmacy",
            "Bachelor of Science in Radiologic Technology",
            "Bachelor of Science in Physical Therapy",
            "Bachelor of Science in Occupational Therapy",
            "Bachelor of Science in Veterinary Medicine",
            "Bachelor of Science in Agriculture and Food Technology",
            "Bachelor of Science in Data Science"});
            this.cbprogram.Location = new System.Drawing.Point(149, 24);
            this.cbprogram.Name = "cbprogram";
            this.cbprogram.Size = new System.Drawing.Size(266, 21);
            this.cbprogram.TabIndex = 15;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(178, 327);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 16;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Student No.:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Last Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(428, 384);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.cbprogram);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtcontactno);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtmiddlename);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtstudentno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "FrmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtstudentno;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtcontactno;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.ComboBox cbprogram;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

