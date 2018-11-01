using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_SmartMovers
{
    public partial class Analytics : Form
    {
        SqlConnection m_con = new DatabaseConnection().getConnection();


        string orderBy = "ASC";
        string startDate = "";
        string endDate = "";

        public Analytics()
        {
            InitializeComponent();
            startDate = startDateTime.Value.Date.ToString();
            endDate = endDateTime.Value.Date.ToString();
            Console.WriteLine("=======================>"+startDate);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doChangeTable();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Descending")
            {
                orderBy = "DESC";
            }
            else
            {
                orderBy = "ASC";
            }
            Console.WriteLine(comboBox1.Text);
            doChangeTable();
        }

        private void doChangeTable()//Order by + Between//
        {
            string select = "SELECT * FROM Job "+
                " WHERE Timestamp BETWEEN '" + startDate + "' AND '" + endDate +
                "' ORDER BY J_Id " + orderBy;
            Console.WriteLine(select);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, m_con);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void startDateTime_ValueChanged(object sender, EventArgs e)
        {
            startDate = startDateTime.Value.Date.ToString();
            endDate = endDateTime.Value.Date.ToString();
            doChangeTable();
        }

        private void endDateTime_ValueChanged(object sender, EventArgs e)
        {
            startDate = startDateTime.Value.Date.ToString();
            endDate = endDateTime.Value.Date.ToString();
            doChangeTable();

        }
        public void searchlocation()
        {
            try
            {
                string sql = "SELECT* FROM Job WHERE J_Start_Location LIKE '" + textBox1.Text +"'+'%'";
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
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchlocation();

        }

        private void orderByToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_in si = new Sign_in();
            si.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin aa = new Admin();
            aa.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
