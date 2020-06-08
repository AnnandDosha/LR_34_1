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
    public partial class Columns : Form
    {
        public Columns()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Columns_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1, "Мололко", 63, false);
            dataGridView1.Rows.Add(2, "Пельмени", 450, false);
            dataGridView1.Rows.Add(3, "Сок", 97, false);
            dataGridView1.Rows.Add(4, "Подгузники", 600, false);
            dataGridView1.Rows.Add(5, "Чипсы", 85, false);
            dataGridView1.Rows.Add(6, "Печенье", 75, false);
            dataGridView1.Rows.Add(7, "Тунец в банке", 100, false);
            dataGridView1.Rows.Add(8, "Авокадо", 100, false);
            dataGridView1.Rows.Add(9, "Манго", 100, false);
            dataGridView1.Rows.Add(10, "Котлеты", 150, false);

            for(int i=0;i< dataGridView1.Rows.Count; i=i+2)
            {
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Blue; 
                }
            }
        }
    }
}
