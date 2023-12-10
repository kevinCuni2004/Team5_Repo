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
            //for ivan need
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

        public SqlDataReader ExcecuteReader(SqlCommand command) //Data reader method with a command as a parameter
        {
            SqlDataReader reader = null;//initialize reader
            command.Connection = new SqlConnection(connStr);//initialize connection using connection string

            try
            {
                command.Connection.Open();//open connection

                reader = command.ExecuteReader(CommandBehavior.CloseConnection);//get reader and close connection
            } catch
            {
                command.Connection.Close();//if error occurred close connection
                throw;
            }
            return reader;//return the reader
        }

        public void ExecutenNonQuery(string table, string field, string value, string email)
        {
            string query = "UPDATE [" + table + "] SET [" + field + "]=@value WHERE [e-mail]=@email;";
            
            SqlCommand command = new SqlCommand(query);//create command using query

            if (field == "date_of_birth")
            {
                var ParsedDoB = DateTime.Parse(value);
                command.Parameters.AddWithValue("@value", ParsedDoB);
            }
            else { command.Parameters.AddWithValue("@value", value); }

            command.Parameters.AddWithValue("@email", email);
            //add parameters

            command.Connection = new SqlConnection(connStr);//create conection

            try
            {
                command.Connection.Open();//open connection

                command.ExecuteNonQuery();//execute statement
            }
            catch
            {
                command.Connection.Close();//catch error and close
                throw;
            }
            finally
            {
                if (command.Connection.State != ConnectionState.Closed) command.Connection.Close();
                //finally if connection remains open, close
            }
        }

        //method to save to database
        public void saveToDB(string sqlQuery)
        {
            //complete once you have data in the database

            // taya's testing 
            using (connToDB = new SqlConnection(connStr))//using the connection created using the connection string
            {
                connToDB.Open();//open connection
                using (SqlCommand command = new SqlCommand(sqlQuery, connToDB))//using the command
                {
                    command.ExecuteNonQuery();//execute statement
                }
            }
            connToDB.Close();//close connection 

        }


        public object ExecuteScalar(string sqlQuery)//get scalar value from query
        {
            using(connToDB = new SqlConnection(connStr))//using connection using connection string
            {
                connToDB.Open();//open connection
                using (SqlCommand command = new SqlCommand(sqlQuery, connToDB))
                {
                    return command.ExecuteScalar();//execute scalar returning statement
                }
            }
        }
        public void openDBConnection()
        {
            if (connToDB.State == System.Data.ConnectionState.Open)
            {
                connToDB.Open();//method to open connToDB
            }
        }
        public SqlConnection getDBConnection()
        {
            return connToDB;//method to return connToDB
        }

        internal string GetConnectionString()
        {
            return Properties.Settings.Default.DBConnectionString;
            //method to return connection string
        }
    }
}
