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
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            labelprogram.Text = "Program: " + DelProgram(StudentInfoClass.Program);
            labelstudentno.Text = "Student No: " + DelStudNo(StudentInfoClass.StudentNo).ToString();
            labellastname.Text = "Last Name: " + DelLastName(StudentInfoClass.LastName);
            labelfirstname.Text = "First Name: " + DelFirstName(StudentInfoClass.FirstName);
            labelmiddlename.Text = "Middle Name: " + DelMiddleName(StudentInfoClass.MiddleName);
            labelage.Text = "Age: " + DelNumAge(StudentInfoClass.Age).ToString();
            labeladdress.Text = "Address: " + DelAddress(StudentInfoClass.Address);
            labelcontactnum.Text = "Contact No.: " + DelNumContactNo(StudentInfoClass.ContactNo).ToString();

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
