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

            DelNumAge = new DelegateText(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            labelprogram.Text = "Program: " + DelProgram(StudentInfoClass.SetProgram);
            labelstudentno.Text = "Student No: " + DelStudNo(StudentInfoClass.SetStudentNo).ToString();
            labelfirstname.Text = "Last Name: " + DelFullName(StudentInfoClass.SetFullName);
            labelage.Text = "Age: " + DelNumAge(StudentInfoClass.SetAge);
            labeladdress.Text = "Address: " + DelAddress(StudentInfoClass.SetAddress);
            labelcontactnum.Text = "Contact No.: " + DelNumContactNo(StudentInfoClass.SetContactNo).ToString();

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
