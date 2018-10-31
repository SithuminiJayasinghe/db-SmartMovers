using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace db_SmartMovers
{
    public class Product
    {//store vehicle details to use in 87...
        public string P_Id;
        public string P_Type_Id;
        public string P_Name;
        public string P_Description;
        public string P_Cost;
  
    }

    class Common
    {
        SqlConnection m_con = new DatabaseConnection().getConnection();

        public Product GetProductRowById(String P_Id)
        {

            try
            {

                string sql = "select * from Product where P_ID ='" + P_Id + "' ";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();

                // We are going to store driver data in this variable (Driver)
                Product p = new Product();

                if (dreader.Read())
                {

                    p.P_Id = dreader[0].ToString();
                    p.P_Type_Id = dreader[1].ToString();
                    p.P_Name = dreader[2].ToString();
                    p.P_Description = dreader[3].ToString();
                    p.P_Cost = dreader[4].ToString();
                    dreader.Close();
                    return p;

                }
                else
                {
                    return null;
                }
            }

            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                m_con.Close();
            }



        }



    }


}
