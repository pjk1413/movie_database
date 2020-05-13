using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Final_Project_2.Database
{
    public static class AccessDB
    {

            public static SqlConnection GetConnection()
            {
                string connectionString = "server=mc-sluggo.stlcc.edu;database=IS253_Kramer;user id=kramer;password=kramer;";
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
            //Add static public methods to expose to the outside world
            //Refer to Murach Chapter 20 on page 663 to see how this is coded
            //You need to reference the remote SQL server IP address
        

    }
}
