using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace db_SmartMovers
{
    public partial class Customer : Form
    {
        SqlConnection m_con = new DatabaseConnection().getConnection();
        public string LASTJID = "";
        public string LASTLID = "";
        public string LASTCID = "";
        public string C_Type_Id = "";
        public int latestcid = 0;

        public int productcost=0;
        public int loadtypecost = 0;
        public int finalcost = 0;
        public int finalpcost=0;
        public int finalltypecost = 0;


        public Product p;
        public LoadType lt;
        
        Common c = new Common();
        

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartMoversDataSet1.Container' table. You can move, or remove it, as needed.
            this.containerTableAdapter.Fill(this.smartMoversDataSet1.Container);
            // TODO: This line of code loads data into the 'smartMoversDataSet1.Lorry' table. You can move, or remove it, as needed.
            this.lorryTableAdapter.Fill(this.smartMoversDataSet1.Lorry);
            // TODO: This line of code loads data into the 'smartMoversDataSet1.Assistant' table. You can move, or remove it, as needed.
            this.assistantTableAdapter.Fill(this.smartMoversDataSet1.Assistant);
            // TODO: This line of code loads data into the 'smartMoversDataSet1.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.smartMoversDataSet1.Driver);
            // TODO: This line of code loads data into the 'smartMoversDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.smartMoversDataSet1.Product);
            // TODO: This line of code loads data into the 'smartMoversDataSet1.Depot' table. You can move, or remove it, as needed.
            this.depotTableAdapter.Fill(this.smartMoversDataSet1.Depot);
            // TODO: This line of code loads data into the 'smartMoversDataSet1.LoadType' table. You can move, or remove it, as needed.
            this.loadTypeTableAdapter.Fill(this.smartMoversDataSet1.LoadType);
            // TODO: This line of code loads data into the 'smartMoversDataSet1.CustomerType' table. You can move, or remove it, as needed.
            this.customerTypeTableAdapter.Fill(this.smartMoversDataSet1.CustomerType);
            // TODO: This line of code loads data into the 'smartMoversDataSet1.CustomerPaymentJob' table. You can move, or remove it, as needed.
            this.customerPaymentJobTableAdapter.Fill(this.smartMoversDataSet1.CustomerPaymentJob);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int cost()
        {
            if (comboBox4.SelectedValue != null && comboBox2.SelectedValue != null)

            {
                string PID = comboBox4.SelectedValue.ToString();
                p = c.GetProductRowById(PID);
                string productcost = "SELECT * FROM Product WHERE P_Id='" + comboBox4.SelectedValue + "'";
                Console.WriteLine(productcost);
                SqlCommand cmd_3 = new SqlCommand(productcost, m_con);
                m_con.Open();
                SqlDataReader dreader_3 = cmd_3.ExecuteReader();

                if (dreader_3.Read())
                {
                    if (dreader_3[0].ToString().Equals(comboBox4.SelectedValue.ToString()))
                    {
                        Console.WriteLine("productcost", dreader_3[4].ToString());
                        productcost = dreader_3[4].ToString();
                        label15.Text = productcost.ToString();
                    }

                    finalpcost = Convert.ToInt32(productcost);
                    dreader_3.Close();


                }


                m_con.Close();




                string LTYPEID = comboBox2.SelectedValue.ToString();
                lt = c.GetLoadTypeRowById(LTYPEID);
                string loadtypecost = "SELECT * FROM LoadType WHERE L_Type_Id='" + comboBox2.SelectedValue + "'";
                Console.WriteLine(loadtypecost);
                SqlCommand cmd_4 = new SqlCommand(loadtypecost, m_con);
                m_con.Open();
                SqlDataReader dreader_4 = cmd_4.ExecuteReader();

                if (dreader_4.Read())
                {
                    if (dreader_4[0].ToString().Equals(comboBox2.SelectedValue.ToString()))
                    {
                        Console.WriteLine("loadtypecost", dreader_4[2].ToString());
                        loadtypecost = dreader_4[2].ToString();
                        label17.Text = loadtypecost.ToString();

                    }

                    finalltypecost = Convert.ToInt32(loadtypecost);
                    dreader_4.Close();


                }

                m_con.Close();



                finalcost = finalpcost + finalltypecost;
                label6.Text = finalcost.ToString();


                return finalcost;

            }
            else
            {
                return 0;
            }

        }


 

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string customer = "select top 1 C_Id from Customer order by C_Id desc;";
            //    Console.WriteLine(customer);
            //    SqlCommand cmd_1 = new SqlCommand(customer, m_con);
            //    m_con.Open();
            //    SqlDataReader dreader_1 = cmd_1.ExecuteReader();

            //    if (dreader_1.Read())
            //    {
            //        LASTCID = dreader_1[0].ToString();
            //        dreader_1.Close();
            //        latestcid = Convert.ToInt32(LASTCID);
            //    }
            //}


            //catch (Exception ex)
            //{

            //    MessageBox.Show("Something went wrong in selecting last customer ID");
            //}
            //finally
            //{
            //    m_con.Close();
            //}


            //try
            //{
            //    string customertypeid = "INSERT INTO Customer (C_Type_Id) Values ('" + comboBox1.SelectedValue + "') WHERE C_Id='latestcid'";
            //    Console.WriteLine(customertypeid);
            //    SqlCommand cmd = new SqlCommand(customertypeid, m_con);
            //    m_con.Open();
            //    cmd.ExecuteReader();
            //    MessageBox.Show("Successful");


            //}


            //catch (Exception ex)
            //{

            //    MessageBox.Show("Something went wrong with inserting customer type");
            //}
            //finally
            //{
            //    m_con.Close();
            //}




            try
            {
                string sql = "INSERT INTO  Job (J_Start_Location,J_End_Location,D_Id,TimeStamp) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox3.SelectedValue + "','" + dateTimePicker1.Value + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Successful");


            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in inserting job details");
            }
            finally
            {
                m_con.Close();
            }




            try
            {
                string Last_Job_Id = "select top 1 J_Id from Job order by J_Id desc;";
                Console.WriteLine(Last_Job_Id);
                SqlCommand cmd_1 = new SqlCommand(Last_Job_Id, m_con);
                m_con.Open();
                SqlDataReader dreader_1 = cmd_1.ExecuteReader();

                if (dreader_1.Read())
                {
                    LASTJID = dreader_1[0].ToString();
                    dreader_1.Close();

                }
            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in selecting last job ID");
            }
            finally
            {
                m_con.Close();
            }

            try
            {
                string sql = "INSERT INTO Load  (L_Type_Id,J_Id,P_Id) Values ('" + comboBox2.SelectedValue + "','"+LASTJID+"','" + comboBox4.SelectedValue + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Successful");


            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in inserting vales into load table");
            }
            finally
            {
                m_con.Close();
            }


            try
            {
                string Last_Load_Id = "select top 1 L_Id from Load order by L_Id desc;";
                Console.WriteLine(Last_Load_Id);
                SqlCommand cmd_2 = new SqlCommand(Last_Load_Id, m_con);
                m_con.Open();
                SqlDataReader dreader_2 = cmd_2.ExecuteReader();

                if (dreader_2.Read())
                {
                    LASTLID = dreader_2[0].ToString();
                    dreader_2.Close();

                }
            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in selecting last load ID");
            }
            finally
            {
                m_con.Close();
            }


            try
            {
                string sql = "INSERT INTO TransportUnit (L_Id,Lorry_Id,Container_Id,Driver_Id,Assistant_Id) Values ('"+LASTLID+"','" + comboBox7.SelectedValue + "','" + comboBox8.SelectedValue + "','" + comboBox5.SelectedValue + "','" + comboBox6.SelectedValue + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Successful");


            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong with inserting transport unit details");
            }
            finally
            {
                m_con.Close();
            }



            try
            {
                string sql = "INSERT INTO Payment (Pay_Amount) Values ('" + finalcost + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Successful");


            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong with inserting payment details");
            }
            finally
            {
                m_con.Close();
            }




        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cost();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cost();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
