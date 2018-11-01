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
    public partial class Admin : Form
    {
        SqlConnection m_con = new DatabaseConnection().getConnection();

        public Admin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO  CustomerType Values ('" + textBox1.Text + "','" + textBox2.Text + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
           

            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in inserting CustomerType details");
            }
            finally
            {
                m_con.Close();
            }


            try
            {
                string sql = "INSERT INTO  LoadType Values ('" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+"')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
    


            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in inserting LoadType details");
            }
            finally
            {
                m_con.Close();
            }


            try
            {
                string sql = "INSERT INTO  ProductType Values ('" + textBox6.Text + "','" + textBox7.Text + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
        


            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in inserting ProductType details");
            }
            finally
            {
                m_con.Close();
            }





            try
            {
                string sql = "INSERT INTO  Product Values ('" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();



            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in inserting Product details");
            }
            finally
            {
                m_con.Close();
            }





            try
            {
                string sql = "INSERT INTO  Depot Values ('" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();



            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in inserting Depot details");
            }
            finally
            {
                m_con.Close();
            }



            try
            {
                string sql = "INSERT INTO  Driver Values ('" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();



            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in inserting Driver details");
            }
            finally
            {
                m_con.Close();
            }



            //try
            //{
            //    string sql = "INSERT INTO  Employee Values ('" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "')";
            //    Console.WriteLine(sql);
            //    SqlCommand cmd = new SqlCommand(sql, m_con);
            //    m_con.Open();
            //    cmd.ExecuteReader();



            //}


            //catch (Exception ex)
            //{

            //    MessageBox.Show("Something went wrong in inserting Employee details");
            //}
            //finally
            //{
            //    m_con.Close();
            //}




            try
            {
                string sql = "INSERT INTO  Assistant Values ('" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
                
            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in inserting Assistant details");
            }
            finally
            {
                m_con.Close();
            }




            //try
            //{
            //    string sql = "INSERT INTO  Employee Values ('" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "')";
            //    Console.WriteLine(sql);
            //    SqlCommand cmd = new SqlCommand(sql, m_con);
            //    m_con.Open();
            //    cmd.ExecuteReader();
                
            //}


            //catch (Exception ex)
            //{

            //    MessageBox.Show("Something went wrong in inserting employee_A details");
            //}
            //finally
            //{
            //    m_con.Close();
            //}




            try
            {
                string sql = "INSERT INTO  Lorry Values ('" + textBox22.Text + "','" + textBox23.Text + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
                
            }
            
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in inserting Lorry details");
            }
            finally
            {
                m_con.Close();
            }



            //try
            //{
            //    string sql = "INSERT INTO  Vehicle Values ('" + textBox22.Text + "')";
            //    Console.WriteLine(sql);
            //    SqlCommand cmd = new SqlCommand(sql, m_con);
            //    m_con.Open();
            //    cmd.ExecuteReader();



            //}


            //catch (Exception ex)
            //{

            //    MessageBox.Show("Something went wrong in inserting Vehicle_L details");
            //}
            //finally
            //{
            //    m_con.Close();
            //}




            try
            {
                string sql = "INSERT INTO  Container Values ('" + textBox24.Text + "','" + textBox25.Text + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();



            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong in inserting Container details");
            }
            finally
            {
                m_con.Close();
            }


            //try
            //{
            //    string sql = "INSERT INTO  Vehicle_C Values ('" + textBox24.Text + "')";
            //    Console.WriteLine(sql);
            //    SqlCommand cmd = new SqlCommand(sql, m_con);
            //    m_con.Open();
            //    cmd.ExecuteReader();



            //}


            //catch (Exception ex)
            //{

            //    MessageBox.Show("Something went wrong in inserting Vehicle_C details");
            //}
            //finally
            //{
            //    m_con.Close();
            //}




        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sign_in si = new Sign_in();
            si.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sign_in si = new Sign_in();
            si.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void text(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Black;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
            textBox3.ForeColor = Color.Black;
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.Clear();
            textBox6.ForeColor = Color.Black;
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            textBox8.Clear();
            textBox8.ForeColor = Color.Black;
        }

        private void textBox13_MouseClick(object sender, MouseEventArgs e)
        {
            textBox13.Clear();
            textBox13.ForeColor = Color.Black;
        }

        private void textBox16_MouseClick(object sender, MouseEventArgs e)
        {
            textBox16.Clear();
            textBox16.ForeColor = Color.Black;
        }

        private void textBox19_MouseClick(object sender, MouseEventArgs e)
        {
            textBox19.Clear();
            textBox19.ForeColor = Color.Black;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_MouseClick(object sender, MouseEventArgs e)
        {
            textBox22.Clear();
            textBox22.ForeColor = Color.Black;
        }

        private void textBox24_MouseClick(object sender, MouseEventArgs e)
        {
            textBox24.Clear();
            textBox24.ForeColor = Color.Black;
        }

        private void textBox9_MouseClick(object sender, MouseEventArgs e)
        {
            textBox9.Clear();
            textBox9.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                m_con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = m_con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from CustomerType where C_Type_Id='" + textBox1.Text + "'";


                SqlDataReader sdr = cmd.ExecuteReader();

                string C_Type_Id = "";
                string C_Type_Name = "";
             

                while (sdr.Read())
                {


                    C_Type_Id = sdr["C_Type_Id"].ToString();
                    C_Type_Name = sdr["C_Type_Name"].ToString();
            


                }
                textBox1.Text = C_Type_Id;
                textBox2.Text = C_Type_Name;
        


                m_con.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "Update CustomerType set C_Type_Name='" + textBox2.Text + "'";
                Console.WriteLine(sql);

                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Successfully updated Customer type");


            }


            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong. PLease check your inputs");
            }
            finally
            {
                m_con.Close();
            }

            textBox14.Clear();
            textBox13.Clear();
            textBox2.Clear();
            textBox1.Clear();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }

        public void groupby()
        {
            try
            {
                string sql = "SELECT TOP (1000) Depot.D_Name, Depot.D_Location, COUNT(Job.J_Id) AS NumberOfJobs FROM  Job INNER JOIN  Depot ON Job.D_Id = Depot.D_Id  GROUP BY Depot.D_Name,Depot.D_Location;";
                Console.WriteLine(sql);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, m_con);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please check your inputs!");
            }
            finally
            {
                m_con.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupby();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Analytics a = new Analytics();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "DELETE from CustomerType where C_Type_Id='" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Successfully deleted vehicle");


            }


            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong. PLease check your inputs");
            }
            finally
            {
                m_con.Close();
            }

                  textBox1.Clear();
                  textBox2.Clear();
        }

        public void customerpayjob()
        {
            try
            {
                string sql = "SELECT c.C_Id,c.C_Name,Job.J_Start_Location,Job.J_End_Location,Job.TimeStamp,Payment.Pay_Amount FROM Customer c INNER JOIN CustomerPaymentJob ON c.C_Id = CustomerPaymentJob.C_Id INNER JOIN Payment ON Payment.Pay_Id = CustomerPaymentJob.Pay_Id INNER JOIN Job ON Job.J_Id = CustomerPaymentJob.J_Id; ";
                Console.WriteLine(sql);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, m_con);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView2.ReadOnly = true;
                dataGridView2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please check your inputs!");
            }
            finally
            {
                m_con.Close();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            customerpayjob();
        }
    }
}
