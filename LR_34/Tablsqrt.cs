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
    public partial class Tablsqrt : Form
    {
        public Tablsqrt()
        {
            InitializeComponent();
        }

        private void sqrtDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Tablsqrt_Load(object sender, EventArgs e)
        {
            sqrtDataGridView.ColumnCount = 9;
            sqrtDataGridView.RowCount = 9;
            for(int i = 1; i <= 9; i++)
            {
                sqrtDataGridView.Columns[i - 1].HeaderText = i.ToString();
                sqrtDataGridView.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
            for(int i = 0; i < sqrtDataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < sqrtDataGridView.Rows.Count; j++)
                {
                    int a = ((j + 1)* 10) + (i + 1);
                    a = a * a;
                    sqrtDataGridView[i, j].Value = a;
                }
            }
        }
    }
}
