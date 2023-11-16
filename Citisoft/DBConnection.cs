using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This file was heavily inspired by the example provided in Week5 (WFA2020withDB_v2.zip)
/*
 * This concept is new for most of us,
 * so using any other way to connect to a data source would prove difficult.
 * I can, however, ensure that we have understood how this algorithm works.
 * ~Kevin
 */

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

            return dataSet;
        }

        //method to save to database
        public void saveToDB()
        {
            //complete once you have data in the database
        }


    }
}
