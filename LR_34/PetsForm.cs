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
        BindingSource bindingSource;

        public PetsForm()
        {
            InitializeComponent();
        }

        private void PetsForm_Load(object sender, EventArgs e)
        {

            bindingSource = new BindingSource();
            bindingSource.DataSource = SmilePets;
            petsDataGridView.DataSource = bindingSource;

            bindingSource.Add(new Pets("Шарик", "Овчарка", 5));
            bindingSource.Add(new Pets("Бобик", "Корги", 3));
            bindingSource.Add(new Pets("Рекс", "Бульдог", 7));
            bindingSource.Add(new Pets("Белка", "Дворняга", 2));
            bindingSource.Add(new Pets("Стрелка", "Шпиц", 3));


            petsDataGridView.Columns.Add("Name", "Имя");
            petsDataGridView.Columns.Add("Poroda", "Порода");
            petsDataGridView.Columns.Add("Age", "Возраст");

            foreach(var a in SmilePets)
            {
                petsDataGridView.Rows.Add(a.Name,a.Poroda,a.Age.ToString());
            }
        }
    }
}
