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
    public partial class Form1 : Form
    {
        string orderBy = "ASC";
        string startDate = "";
        string endDate = "";

        public Form1()
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

        private void doChangeTable()
        {
            string select = "SELECT * FROM Job "+
                " WHERE Timestamp BETWEEN '" + startDate + "' AND '" + endDate +
                "' ORDER BY J_Id " + orderBy;
            Console.WriteLine(select);
            SqlConnection c = new SqlConnection("Data Source=DESKTOP-MHS4TMT\\SQLEXPRESS;Initial Catalog=SmartMovers;Integrated Security=True"); // Your Connection String here
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, c);

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
    }
}
