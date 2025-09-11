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
        //add access modifier
        private string _FullName;
        private int _Age;
        private long _StudentNo;
        private long _ContactNo;



        //combo box 
        private void Next_Click(object sender, EventArgs e)
        {

            StudentInfoClass.SetFullName = FullName(txtfirstname.Text, txtlastname.Text, txtmiddlename.Text);
            StudentInfoClass.SetAddress = txtaddress.Text.ToString();
            StudentInfoClass.SetProgram = cbprogram.Text.ToString();
            StudentInfoClass.SetGender = cbGender.Text.ToString();
            StudentInfoClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            StudentInfoClass.SetAge = Age(txtage.Text); ;
            StudentInfoClass.SetContactNo = ContactNo(txtcontactno.Text);
            StudentInfoClass.SetStudentNo = StudentNumber(txtstudentno.Text);

            FrmConfirm frmConfirm = new FrmConfirm();
            DialogResult result = frmConfirm.ShowDialog();
        }
        public long StudentNumber(string studNum)
        {
            try
            {
                if (string.IsNullOrEmpty(studNum))
                {
                    throw new ArgumentNullException("Student Number cannot be empty!");
                }
                else if (!Regex.IsMatch(studNum, @"^[0-9]+$"))
                {
                    throw new FormatException("Student Number must contain digits only.");
                }
                else if (studNum.Length > 10) // example length check
                {
                    throw new OverflowException("Student Number is too long.");
                }
                else
                {
                    _StudentNo = long.Parse(studNum);
                }
            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show(a.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException o)
            {
                MessageBox.Show(o.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Optional cleanup
            }

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            try
            {
                if (string.IsNullOrEmpty(Contact))
                {
                    throw new ArgumentNullException("Contact Number cannot be empty!");
                }
                else if (!Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    throw new FormatException("Contact Number must be 10 or 11 digits.");
                }
                else
                {
                    _ContactNo = long.Parse(Contact);
                }
            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show(a.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException o)
            {
                MessageBox.Show(o.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Optional cleanup
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            try
            {
                if (string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(MiddleInitial))
                {
                    throw new ArgumentNullException("Full Name fields cannot be empty!");
                }
                else if (!Regex.IsMatch(LastName, @"^[a-zA-Z]+$") ||
                         !Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") ||
                         !Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                {
                    throw new FormatException("Full Name must contain alphabetic characters only.");
                }
                else if (LastName.Length < 2 || FirstName.Length < 2)
                {
                    throw new IndexOutOfRangeException("Full Name fields are too short.");
                }
                else
                {
                    _FullName = LastName + ", " + FirstName + " " + MiddleInitial;
                }
            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show(a.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException i)
            {
                MessageBox.Show(i.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Optional cleanup
            }

            return _FullName;
        }

        public int Age(string age)
        {
            try
            {
                if (string.IsNullOrEmpty(age))
                {
                    throw new ArgumentNullException("Age cannot be empty!");
                }
                else if (!Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    throw new FormatException("Age must be numeric and 1-3 digits.");
                }
                else if (int.Parse(age) > 120)
                {
                    throw new OverflowException("Age entered is not realistic.");
                }
                else
                {
                    _Age = Int32.Parse(age);
                }
            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show(a.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException o)
            {
                MessageBox.Show(o.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Optional cleanup
            }

            return _Age;
        }
    }
}


            