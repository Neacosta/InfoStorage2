using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InfoStorage

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Customer customer;
        Interests interests;

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            this.AddCustomer();
            CustomerDB.AddCustomers(customer);

            interests = new Interests();
            this.AddInsterests();
            InterestsDB.AddInsterests(interests);
;        }
        private void AddInsterests()
        {
            interests.CustomerID = Convert.ToInt32(txtID.Text);
            interests.BuyOrSell = txtBuyOrSale.Text;
            interests.Rooms = Convert.ToInt32(txtRooms.Text);
            interests.Locations = txtLocationOfInterest.Text;

        }
        private void AddCustomer()

        {
            if (IsValidData())

            {   // This information gets inserted into the customer table
                customer.CustomerID = Convert.ToInt32(txtID.Text);
                customer.LName = txtLName.Text;
                customer.FName = txtFName.Text;
                customer.PhoneNumber = mskPhoneNumber.Text;
                customer.WorkOccupation = txtWorkOccupation.Text;
                customer.CreditScore = Convert.ToInt32(txtCreditScore.Text);
                customer.Agent = txtAgent.Text;
                customer.Children = Convert.ToInt32(txtChildren.Text);
                customer.ReferredBy = txtReferredBy.Text;
                customer.TypeOfLoan = textBox5.Text;
                // this information gets inserted into the interests table


            }


        }


        private bool IsValidData()
        {
            return Validator.IsPresent(txtID) &&
                   Validator.IsPresent(txtLName) &&
                   Validator.IsPresent(txtFName) &&
                   Validator.IsPresent(textBox5) &&
                   Validator.IsPresent(txtAgent) &&
                   Validator.IsPresent(txtBuyOrSale) &&
                   Validator.IsPresent(txtCreditScore) &&
                   Validator.IsPresent(txtLocationOfInterest) &&
                    Validator.IsPresent(txtChildren) &&
                   Validator.IsPresent(txtRooms) &&
                   Validator.IsPresent(txtReferredBy) &&


                   Validator.IsInt32(txtChildren) &&
                    Validator.IsInt32(txtRooms) &&
                    Validator.IsInt32(txtCreditScore);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
