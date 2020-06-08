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
    public partial class PetsForm : Form
    {
        List<Pets> SmilePets = new List<Pets>(5);
        

        public PetsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PetsForm_Load(object sender, EventArgs e)
        {
            SmilePets.Add(new Pets("Шарик", "Овчарка", 5));
            SmilePets.Add(new Pets("Бобик", "Корги", 3));
            SmilePets.Add(new Pets("Рекс", "Бульдог", 7));
            SmilePets.Add(new Pets("Белка", "Дворняга", 2));
            SmilePets.Add(new Pets("Стрелка", "Шпиц", 3));

            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Poroda", "Порода");
            dataGridView1.Columns.Add("Age", "Возраст");

            foreach(var a in SmilePets)
            {
                dataGridView1.Rows.Add(a.Name,a.Poroda,a.Age.ToString());
            }
        }
    }
}
