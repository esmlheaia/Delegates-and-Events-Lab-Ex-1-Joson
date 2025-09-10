using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _FullName;
        private int _Age;
        private long _StudentNo;
        private long _ContactNo;

        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            StudentInfoClass.SetFullName = txtfirstname.Text.ToString();
            StudentInfoClass.SetAddress = txtaddress.Text.ToString();
            StudentInfoClass.SetProgram = cbprogram.Text.ToString();//combo box
            StudentInfoClass.SetAge =txtage.Text.ToString();
            StudentInfoClass.SetContactNo = (int)Convert.ToInt64(txtcontactno.Text);
            StudentInfoClass.SetStudentNo = (int)Convert.ToInt64(txtstudentno.Text);

            FrmConfirm frmConfirm = new FrmConfirm();
            DialogResult result = frmConfirm.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (result == DialogResult.OK)
                {

                    MessageBox.Show("Registration Successful!");


                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is TextBox)
                            ((TextBox)ctrl).Clear();

                        if (ctrl is ComboBox)
                            ((ComboBox)ctrl).SelectedIndex = -1;
                    }
                }
                else if (result == DialogResult.Cancel)
                {

                    MessageBox.Show("Registration Cancelled. You may edit your details.");

                }
            }
        }

    }
}
