using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_34
{
    class Pets
    {
        private string name;
        private string poroda;
        private int age;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Poroda
        {
            get
            {
                return poroda;
            }

            set
            {
                poroda = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public Pets(string name, string poroda, int age)
        {
            this.name = name;
            this.poroda = poroda;
            this.age = age;
        }
    }
}
