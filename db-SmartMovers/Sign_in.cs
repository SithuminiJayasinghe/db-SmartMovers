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
    public partial class Sign_in : Form
    {
        static string constring = "Data Source=DESKTOP-MHS4TMT\\SQLEXPRESS;Initial Catalog=SmartMovers;Integrated Security=True";
        SqlConnection m_con = new SqlConnection(constring);

        public static string USER_ID = "";


        public Sign_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "admin" && password == "123")
            {

                Admin admin = new Admin();
                admin.Visible = true;
                this.Hide();
            }



            try
            {

                string sql = "select * from Customer where C_Name ='" + textBox1.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();

                if (dreader.Read())
                {
                    if (dreader[5].ToString().Equals(textBox2.Text))
                    {

                        USER_ID = dreader[5].ToString();


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
                    else
                    {
                        Customer fc = new Customer();
                        fc.Show();
                        this.Hide();
                        textBox1.Clear();

                        textBox2.Clear();

                    }








                }

                dreader.Close();


            }

            catch (Exception ex)
            {

                MessageBox.Show("Error");
            }
            finally
            {
                m_con.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_up su = new Sign_up();
            su.Show();
            this.Hide();

        }
    }
}
