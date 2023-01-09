using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetShop
{
    class Cat : Pet
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public void MakesNoise()
        {
            Console.WriteLine($"{this.Name} goes meow!");
        }
    }
}
