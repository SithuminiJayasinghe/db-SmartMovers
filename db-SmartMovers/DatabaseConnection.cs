using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace db_SmartMovers
{
    public class DatabaseConnection
    {
        static string constring = "Data Source=DESKTOP-MHS4TMT\\SQLEXPRESS;Initial Catalog=SmartMovers;Integrated Security=True";
        SqlConnection m_con = new SqlConnection(constring);

        public DatabaseConnection()
        {

        }

        public SqlConnection getConnection()
        {
            return m_con;
        }
    }
   
}
