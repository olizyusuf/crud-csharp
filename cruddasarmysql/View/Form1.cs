using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cruddasarmysql.Controller;
using cruddasarmysql.View;

namespace cruddasarmysql
{
    public partial class Form1 : Form
    {

        private ProdukC controller;
       
        public Form1()
        {
            InitializeComponent();
            controller = new ProdukC();
            LoadDataProduk();
        }

        private void LoadDataProduk()
        {
            dataGridView1.DataSource = controller.getAllProduk();
            dataGridView1.Columns["hBeli"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["hBeli"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["hJual"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["hJual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["kuantiti"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            LoadDataProduk();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
