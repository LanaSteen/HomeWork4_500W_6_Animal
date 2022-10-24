using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500W_6_Animal
{
    internal class Cat : Animal
    {
        public string Sound = "Meawing";
        public Cat(int Age, string Name, string Gender) : base(Age, Name, Gender)
        {
        }
        public override string Sounds()
        {
            return this.Sound;
        }

    }
}
