using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_34
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Columns columns = new Columns();
            columns.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tablsqrt tablsqrt = new Tablsqrt();
            tablsqrt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PetsForm pets = new PetsForm();
            pets.Show();

        }
    }
}
