using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace groupProject
{
    public static class travelexpertsDB
    {
        public static SqlConnection GetConnection()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|\\travelexperts.mdf; Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connString);
            return conn;

        }
    }
}
