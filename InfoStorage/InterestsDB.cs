using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InfoStorage
{
    class InterestsDB
    {


        public static void AddInsterests(Interests interests)
        {

            SqlConnection connection = ClientInfoStorageDB.GetConnection();

            string insertStatement =
                "INSERT Interests " +
                "(CustomerID, BuyOrSell, Rooms, Locations) " +
                "VALUES (@CustomerID,@BuyOrSell, @Rooms, @Locations)";


            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@CustomerID", interests.CustomerID);
            insertCommand.Parameters.AddWithValue("@BuyOrSell", interests.BuyOrSell);
            insertCommand.Parameters.AddWithValue("@Rooms", interests.Rooms);
            insertCommand.Parameters.AddWithValue("@Locations", interests.Locations);
            
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
