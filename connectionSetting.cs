using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this sytem for database requred

using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;



namespace r_ServiceApp_Beta_V._1._2
{
    public static class connectionSetting          //DESKTOP-C8R90DV\SQLEXPRESS
    {
        public static SqlConnection CON = new SqlConnection(@"Data Source=DESKTOP-C8R90DV\SQLEXPRESS;Initial Catalog=r_ServiceDB;User ID=sa;Password=tukiem12345");

        public static SqlCommand cmd = new SqlCommand();
        public static void OpenConnection()
        {
            CON.Open();
        }
        public static void CloseConnection()
        {
            CON.Close();
        }
    }
}
