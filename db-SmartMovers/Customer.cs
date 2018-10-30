using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_SmartMovers
{
    public partial class Customer : Form
    {
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
    }
}
