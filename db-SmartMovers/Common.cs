using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace db_SmartMovers
{

    public class Customerdetails
    {
        public string C_Id;
        public string C_Type_Id;
        public string C_Name;
        public string C_Address;
        public string C_Email;
        public string C_Password;


    }


    public class Product
    {
        public string P_Id;
        public string P_Type_Id;
        public string P_Name;
        public string P_Description;
        public string P_Cost;
  
    }


    public class LoadType
    {
        public string L_Type_Id;
        public string L_Type_Name;
        public string L_Type_Cost;
       

    }



    class Common
    {
        SqlConnection m_con = new DatabaseConnection().getConnection();


        public Customerdetails GetCustomerRowById(String C_Id)
        {

            try
            {

                string sql = "select * from Customer where C_Id ='" + C_Id + "' ";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();

                // We are going to store Customer data in this variable (Customer)
                Customerdetails cus = new Customerdetails();

                if (dreader.Read())
                {

                    cus.C_Id = dreader[0].ToString();
                    cus.C_Type_Id = dreader[1].ToString();
                    cus.C_Name = dreader[2].ToString();
                    cus.C_Address = dreader[3].ToString();
                    cus.C_Email = dreader[4].ToString();
                    cus.C_Password = dreader[5].ToString();

                    dreader.Close();
                    return cus;

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





        public Product GetProductRowById(String P_Id)
        {

            try
            {

                string sql = "select * from Product where P_Id ='" + P_Id + "' ";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();

                // We are going to store product data in this variable (product)
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



        public LoadType GetLoadTypeRowById(String L_Type_Id)
        {

            try
            {

                string sql = "select * from LoadType where L_Type_Id ='" + L_Type_Id + "' ";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();

                // We are going to store loadtype data in this variable (loadtype)

                LoadType lt = new LoadType();

                if (dreader.Read())
                {

                    lt.L_Type_Id = dreader[0].ToString();
                    lt.L_Type_Name = dreader[1].ToString();
                    lt.L_Type_Cost = dreader[2].ToString();
                  
                    return lt;

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
