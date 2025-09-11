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


        public long StudentNumber(string studNum)
        {
            try
            {
                if (!string.IsNullOrEmpty(studNum))
                {
                    _StudentNo = long.Parse(studNum);
                }
                else
                {
                    throw new ArgumentNullException("Student Number cannot be empty!");
                }
            }
            catch (FormatException) // this exception if their is a letter or symbol in input
            {
                MessageBox.Show("Student No. must contain digits only.");
            }
            catch (ArgumentNullException ex) // this exception if the input box is null
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException) // this exception if the number is too long 
            {
                MessageBox.Show("Please enter a valid Number");
            }
            finally
            {

            }

                return _StudentNo;
            }


        public long ContactNo(string Contact)
        {
            try
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);
                }
                else
                {
                    throw new FormatException("Contact no. must be 11 digits"); 
                }
            }
            catch (FormatException ex) // this exception if thye format is wrong or not 11 digits
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException) // this exception if the number is too long like you eneter a 12 digits
            {
                MessageBox.Show("Contact number is too long");
            }
            finally
            {

            }
                    return _ContactNo;
            }
          

        public string FullName(string LastName, string FirstName, string MiddleName)
        {
            try
            {
                if (!string.IsNullOrEmpty(LastName) || !string.IsNullOrEmpty(FirstName) || !string.IsNullOrEmpty(MiddleName) || Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleName, @"^[a-zA-Z]+$"))
                {
                    _FullName = LastName + ", " + FirstName + ", " + MiddleName;
                }
                else
                {
                    throw new ArgumentNullException("Invalid FullName and must be alphabetic");
                }
            }
            catch (ArgumentNullException ex) // this exception if the input is null
            {
                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException) // this exception if not complete the input fields 
            {
                MessageBox.Show("Name input is incomplete");
            }
            finally
            {

            }

                    return _FullName;
        }

        public int Age(string age)
        {
            try
            {
                if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    _Age = Int32.Parse(age);
                }
                else
                {
                    throw new FormatException("Age must be numeric and 1-3 digits");
                }
            }
            catch (FormatException ex) // this exception if the digits is too long in 3 digits
            {
                MessageBox.Show(ex.Message);
            }
            catch(OverflowException) // if the digits is  not valid 
            {
                MessageBox.Show("Age is too long");
            }


                    return _Age;
        }
        //combo box 
        private void Next_Click(object sender, EventArgs e)
        {
            StudentInfoClass.SetFullName = FullName(txtfirstname.Text,txtlastname.Text, txtmiddlename.Text);
            StudentInfoClass.SetAddress = txtaddress.Text.ToString();
            StudentInfoClass.SetProgram = cbprogram.Text.ToString();
            StudentInfoClass.SetGender = cbGender.Text.ToString();
            StudentInfoClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
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
