using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetShop
{
    class Dog : Pet
    {
        public Dog(string name, int age, string breed) : base(name, age, breed)
        {
            Breed = breed;
        }

        public void MakesNoise()
        {
            Console.WriteLine($"{this.Name} goes woof!");
        }
    }
}
