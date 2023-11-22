using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//This file was heavily inspired by the example provided in Week5 (WFA2020withDB_v2.zip)
/*
 * This concept is new for most of us,
 * so using any other way to connect to a data source would prove difficult.
 * I can, however, ensure that we have understood how this algorithm works.
 * ~Kevin
 */
//test comment

namespace Citisoft
{
    class DBConnection
    {
        //created object of the class
        private static DBConnection _instance;

        //Created connection string variable
        private string connStr;

        //Initialized connection to database
        private SqlConnection connToDB;

        //created constructor for class
        private DBConnection()
        {
            //stored connection string into variable
            connStr = Properties.Settings.Default.DBConnectionString;
        }

        //static method that creates a unique object of the class
        public static DBConnection getInstance()
        {
            //if instance is null, create the object
            if (_instance == null)
            {
                return _instance = new DBConnection();
            }
            return _instance;
        }

        //will return the dataset based on the query it has as a parameter
        public DataSet getDataSet(string sqlQuery)
            //Useless
        {
            //creaing an empty dataset
            DataSet dataSet = new DataSet();

            using (connToDB = new SqlConnection(connStr))
            {
                //open the connection
                connToDB.Open();

                //creating the data adapter to send the query to the database
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                //fill in the dataset
                dataAdapter.Fill(dataSet);
            }

            connToDB.Close();

            return dataSet;
        }

        public SqlDataReader ExcecuteReader(SqlCommand command)
        {
            SqlDataReader reader = null;
            command.Connection = new SqlConnection(connStr);

            try
            {
                command.Connection.Open();

                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            } catch
            {
                command.Connection.Close();
                throw;
            }
            return reader;
        }

        public void ExecutenNonQuery(SqlCommand command)
        {
            command.Connection = new SqlConnection(connStr);

            try
            {
                command.Connection.Open();

                command.ExecuteNonQuery();
            }
            catch
            {
                command.Connection.Close();
                throw;
            }
            finally
            {
                if (command.Connection.State != ConnectionState.Closed) command.Connection.Close();
            }
        }

        //method to save to database
        public void saveToDB(string sqlQuery)
        {
            //complete once you have data in the database

            // taya's testing 
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, connToDB))
                {
                    command.ExecuteNonQuery();
                }
            }
            connToDB.Close();

        }

        public void searchDB(string sqlQuery, string email)
        {
            //complete once you have data in the database

            // taya's testing 
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, connToDB))
                {
                    command.Parameters.Add(new SqlParameter("email", email));
                    command.ExecuteNonQuery();
                }
            }
            connToDB.Close();

        }

        //taya's testing 

        public object ExecuteScalar(string sqlQuery)
        {
            using(connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, connToDB))
                {
                    return command.ExecuteScalar();
                }
            }
        }


    }
}
