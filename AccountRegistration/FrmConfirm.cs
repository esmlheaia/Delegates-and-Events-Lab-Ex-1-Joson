using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {
        public FrmConfirm()
        {
            InitializeComponent();
        }

        // generate a form 
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            labelprogram.Text = "Program: " + StudentInfoClass.SetProgram;
            labelstudentno.Text = "Student No: " +StudentInfoClass.SetStudentNo.ToString();
            labelfirstname.Text = "Name: " + StudentInfoClass.SetFullName;
            labelage.Text = "Age: " + StudentInfoClass.SetAge;
            labeladdress.Text = "Address: " + StudentInfoClass.SetAddress;
            labelcontactnum.Text = "Contact No.: " + StudentInfoClass.SetContactNo.ToString();
            labelgender.Text = "Gender: " + StudentInfoClass.SetGender;
            labelbirthday.Text = "Birthday: " + StudentInfoClass.SetBirthday;

        }
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void bSubmit_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
