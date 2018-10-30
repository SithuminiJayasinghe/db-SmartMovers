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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO TransportUnit (Lorry_Id,Container_Id,Driver_Id,Assistant_Id) Values ('" + comboBox7.SelectedValue + "','" + comboBox8.SelectedValue + "','" + comboBox5.SelectedValue + "','"+comboBox6.SelectedValue+"')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Successful");


            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong. PLease check your inputs");
            }
            finally
            {
                m_con.Close();
            }


            try
            {
                string sql = "INSERT INTO  (J_Start_Location,J_End_Location,D_Id,TimeStamp) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox3.SelectedValue + "','" + dateTimePicker1.Value + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Successful");


            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong. PLease check your inputs");
            }
            finally
            {
                m_con.Close();
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
