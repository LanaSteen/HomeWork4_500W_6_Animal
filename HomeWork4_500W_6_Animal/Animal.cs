using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500W_6_Animal
{
    public class Animal
    {
        //age, name and gender.
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public Animal(int Age, string Name, string Gender)
        {
            this.Age = Age;

            this.Name = Name;

            this.Gender = Gender;

        }

        public virtual string Sounds()
        {
            return null;
        }

    }
}
