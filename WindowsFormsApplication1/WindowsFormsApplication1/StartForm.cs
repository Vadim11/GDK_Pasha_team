using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewForm f = new ViewForm();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderForm f1 = new OrderForm();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportForm f2 = new ReportForm();
            f2.Show();
        }
    }
}
