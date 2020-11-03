using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace InfoStorage
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private static string title = "Entry Error";
        private void btnButton_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "yussetty" && txtPassword.Text == "111")
            {
                MessageBox.Show("Welcome Yussetty");
                //nameErrorProvider.SetError(txtUserName, null);
                //passwordErrorProvider.SetError(txtPassword, null);
                grbAction.Visible = true;
            }
            /*else if  (txtUserName.Text != "yussetty" && txtPassword.Text != "111")
            {
                
                MessageBox.Show("Wrong password or username");
            }*/
            else
            {   // Message that tells ou your input is invalid plus error messages
               // MessageBox.Show("Valid data needed-Try again", "Warning");
                //nameErrorProvider.SetError(txtUserName, "Must be lower case only");
                //passwordErrorProvider.SetError(txtPassword, "Must be numbers only");
                IsValidData();
            }

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var addForm = new Form1();
            var button = addForm.ShowDialog();
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtUserName) &&
                   Validator.IsPresent(txtPassword) &&
                   Validator.IsInt32(txtPassword);
                  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
