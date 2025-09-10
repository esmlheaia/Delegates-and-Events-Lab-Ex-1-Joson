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
        private DelegateText DelProgram, DelFullName, DelAddress,DelGender, DelBirthday, DelNumAge;
        private DelegateNumber DelNumContactNo, DelStudNo;

    

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelFullName = new DelegateText(StudentInfoClass.GetFullName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelAddress = new DelegateText(StudentInfoClass.GetGender);
            DelAddress = new DelegateText(StudentInfoClass.GetBirthday);

            DelNumAge = new DelegateText(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
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
