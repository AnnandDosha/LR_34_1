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
            columnsDataGridView.Rows.Add(1, "Мололко", 63 + " руб.", false);
            columnsDataGridView.Rows.Add(2, "Пельмени", 450 + " руб.", false);
            columnsDataGridView.Rows.Add(3, "Сок", 97 + " руб.", false);
            columnsDataGridView.Rows.Add(4, "Подгузники", 600 + " руб.", false);
            columnsDataGridView.Rows.Add(5, "Чипсы", 85 + " руб.", false);
            columnsDataGridView.Rows.Add(6, "Печенье", 75 + " руб.", false);
            columnsDataGridView.Rows.Add(7, "Тунец в банке", 100 + " руб.", false);
            columnsDataGridView.Rows.Add(8, "Авокадо", 100 + " руб.", false);
            columnsDataGridView.Rows.Add(9, "Манго", 100 + " руб.", false);
            columnsDataGridView.Rows.Add(10, "Котлеты", 150 + " руб.", false);

            for(int i=0;i <= columnsDataGridView.Rows.Count; i=i+2)
            {
            for (int j = 0; j < columnsDataGridView.Columns.Count; j++)
                {
                    columnsDataGridView.Rows[i+2/2].Cells[j].Style.BackColor = Color.YellowGreen; 
                }
            }
        }
    }
}
