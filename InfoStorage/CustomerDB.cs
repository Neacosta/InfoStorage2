using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InfoStorage
{
    class CustomerDB
    {


        public static void AddCustomers(Customer customer)
        {

            SqlConnection connection = ClientInfoStorageDB.GetConnection();
            
            string insertStatement = 
                "INSERT Customers " + 
                "(CustomerID,FName, LName, PhoneNumber, CreditScore, WorkOccupation, Agent, Children, Referred, TypeOfLoan) " +
                "VALUES (@CustomerID,@FName, @LName, @PhoneNumber, @CreditScore, @WorkOccupation, @Agent, @Children, @Referred, @TypeOfLoan )";
                

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
            insertCommand.Parameters.AddWithValue("@FName", customer.FName);
            insertCommand.Parameters.AddWithValue("@LName", customer.LName);
            insertCommand.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
            insertCommand.Parameters.AddWithValue("@CreditScore", customer.CreditScore);
            insertCommand.Parameters.AddWithValue("@WorkOccupation", customer.WorkOccupation);
            insertCommand.Parameters.AddWithValue("@Agent", customer.Agent);
            insertCommand.Parameters.AddWithValue("@Children", customer.Children);
            insertCommand.Parameters.AddWithValue("@Referred", customer.ReferredBy);
            insertCommand.Parameters.AddWithValue("@TypeOfloan", customer.TypeOfLoan);
            try
            {
                //open the connection to the database.
                connection.Open();

                //execute the insert statement
                insertCommand.ExecuteNonQuery();

                //inform user the record has been inserted.
                MessageBox.Show("Record Added", "Success");

            }
            catch (Exception ex)
            {
                //thow exception if insert fails.
                throw ex;
            }
            finally
            {
                //close the database connection.
                connection.Close();
            }
        }


    }




}
