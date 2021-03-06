﻿namespace db_SmartMovers
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartMoversDataSet1 = new db_SmartMovers.SmartMoversDataSet1();
            this.customerPaymentJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerPaymentJobTableAdapter = new db_SmartMovers.SmartMoversDataSet1TableAdapters.CustomerPaymentJobTableAdapter();
            this.customerTypeTableAdapter = new db_SmartMovers.SmartMoversDataSet1TableAdapters.CustomerTypeTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.loadTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadTypeTableAdapter = new db_SmartMovers.SmartMoversDataSet1TableAdapters.LoadTypeTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.depotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depotTableAdapter = new db_SmartMovers.SmartMoversDataSet1TableAdapters.DepotTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new db_SmartMovers.SmartMoversDataSet1TableAdapters.ProductTableAdapter();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.lorryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.containerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new db_SmartMovers.SmartMoversDataSet1TableAdapters.DriverTableAdapter();
            this.assistantTableAdapter = new db_SmartMovers.SmartMoversDataSet1TableAdapters.AssistantTableAdapter();
            this.lorryTableAdapter = new db_SmartMovers.SmartMoversDataSet1TableAdapters.LorryTableAdapter();
            this.containerTableAdapter = new db_SmartMovers.SmartMoversDataSet1TableAdapters.ContainerTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartMoversDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job start location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Job end location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date and time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nearest depot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Load type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Driver";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Assistant";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Lorry";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Container capacity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Total cost";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customerTypeBindingSource
            // 
            this.customerTypeBindingSource.DataMember = "CustomerType";
            this.customerTypeBindingSource.DataSource = this.smartMoversDataSet1;
            // 
            // smartMoversDataSet1
            // 
            this.smartMoversDataSet1.DataSetName = "SmartMoversDataSet1";
            this.smartMoversDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerPaymentJobBindingSource
            // 
            this.customerPaymentJobBindingSource.DataMember = "CustomerPaymentJob";
            this.customerPaymentJobBindingSource.DataSource = this.smartMoversDataSet1;
            // 
            // customerPaymentJobTableAdapter
            // 
            this.customerPaymentJobTableAdapter.ClearBeforeFill = true;
            // 
            // customerTypeTableAdapter
            // 
            this.customerTypeTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.loadTypeBindingSource;
            this.comboBox2.DisplayMember = "L_Type_Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "L_Type_Id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // loadTypeBindingSource
            // 
            this.loadTypeBindingSource.DataMember = "LoadType";
            this.loadTypeBindingSource.DataSource = this.smartMoversDataSet1;
            // 
            // loadTypeTableAdapter
            // 
            this.loadTypeTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.depotBindingSource;
            this.comboBox3.DisplayMember = "D_Name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(143, 124);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.ValueMember = "D_Id";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // depotBindingSource
            // 
            this.depotBindingSource.DataMember = "Depot";
            this.depotBindingSource.DataSource = this.smartMoversDataSet1;
            // 
            // depotTableAdapter
            // 
            this.depotTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.productBindingSource;
            this.comboBox4.DisplayMember = "P_Name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(143, 155);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 21;
            this.comboBox4.ValueMember = "P_Id";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.smartMoversDataSet1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.driverBindingSource;
            this.comboBox5.DisplayMember = "Driver_Name";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(143, 226);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 22;
            this.comboBox5.ValueMember = "Driver_Id";
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.smartMoversDataSet1;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.assistantBindingSource;
            this.comboBox6.DisplayMember = "Assistant_Name";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(143, 263);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 23;
            this.comboBox6.ValueMember = "Assistant_Id";
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "Assistant";
            this.assistantBindingSource.DataSource = this.smartMoversDataSet1;
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.lorryBindingSource;
            this.comboBox7.DisplayMember = "Lorry_Id";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(143, 290);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 24;
            this.comboBox7.ValueMember = "Lorry_Id";
            // 
            // lorryBindingSource
            // 
            this.lorryBindingSource.DataMember = "Lorry";
            this.lorryBindingSource.DataSource = this.smartMoversDataSet1;
            // 
            // comboBox8
            // 
            this.comboBox8.DataSource = this.containerBindingSource;
            this.comboBox8.DisplayMember = "Container_Capacity";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(143, 317);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 25;
            this.comboBox8.ValueMember = "Container_Id";
            // 
            // containerBindingSource
            // 
            this.containerBindingSource.DataMember = "Container";
            this.containerBindingSource.DataSource = this.smartMoversDataSet1;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // lorryTableAdapter
            // 
            this.lorryTableAdapter.ClearBeforeFill = true;
            // 
            // containerTableAdapter
            // 
            this.containerTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "...";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(355, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Product cost";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(448, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(355, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Load type cost";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(448, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "...";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(561, 415);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Customer";
            this.Text = "Request a service";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartMoversDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private SmartMoversDataSet1 smartMoversDataSet1;
        private System.Windows.Forms.BindingSource customerPaymentJobBindingSource;
        private SmartMoversDataSet1TableAdapters.CustomerPaymentJobTableAdapter customerPaymentJobTableAdapter;
        private System.Windows.Forms.BindingSource customerTypeBindingSource;
        private SmartMoversDataSet1TableAdapters.CustomerTypeTableAdapter customerTypeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource loadTypeBindingSource;
        private SmartMoversDataSet1TableAdapters.LoadTypeTableAdapter loadTypeTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource depotBindingSource;
        private SmartMoversDataSet1TableAdapters.DepotTableAdapter depotTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SmartMoversDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private SmartMoversDataSet1TableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private SmartMoversDataSet1TableAdapters.AssistantTableAdapter assistantTableAdapter;
        private System.Windows.Forms.BindingSource lorryBindingSource;
        private SmartMoversDataSet1TableAdapters.LorryTableAdapter lorryTableAdapter;
        private System.Windows.Forms.BindingSource containerBindingSource;
        private SmartMoversDataSet1TableAdapters.ContainerTableAdapter containerTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}