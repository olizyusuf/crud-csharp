using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cruddasarmysql.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }
    }
}
