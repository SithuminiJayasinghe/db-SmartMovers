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
    public partial class Sign_up : Form
    {
        static string constring = "Data Source=DESKTOP-MHS4TMT\\SQLEXPRESS;Initial Catalog=SmartMovers;Integrated Security=True";
        SqlConnection m_con = new SqlConnection(constring);

        public Sign_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Customer (C_Name,C_Address,C_Email,C_Password) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Successfully signed up!");


            }


            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong");
            }
            finally
            {
                m_con.Close();
            }




            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Focus();
                textBox1.BackColor = System.Drawing.Color.LightPink;



            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Focus();
                textBox2.BackColor = System.Drawing.Color.LightPink;



            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Focus();
                textBox3.BackColor = System.Drawing.Color.LightPink;



            }

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Focus();
                textBox4.BackColor = System.Drawing.Color.LightPink;



            }


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();




            Customer fc = new Customer();
            fc.Show();

            this.Hide();



        }
    }
}
