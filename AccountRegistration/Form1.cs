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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = txtfirstname.Text.ToString();
            StudentInfoClass.LastName = txtlastname.Text.ToString();
            StudentInfoClass.MiddleName = txtmiddlename.Text.ToString();
            StudentInfoClass.Address = txtaddress.Text.ToString();
            StudentInfoClass.Program = cbprogram.Text.ToString();//combo box
            StudentInfoClass.Age = Convert.ToInt64(txtage.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(txtcontactno.Text);
            StudentInfoClass.StudentNo = Convert.ToInt64(txtstudentno.Text);

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
