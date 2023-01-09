using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetShop
{

    class Pet
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Breed { get; set; }
        public string? Description { get; }

        public Pet(string? name, int age, string? breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
            Description = $"{Name} is a {Age} year old {Breed}.";
        }

        public Pet(string? name,string? breed)
        {
            Name = name;
            Breed = breed;
            Description = $"{Name} is a {Breed}.";
        }

        public Pet(string? name, int age)
        {
            Name = name;
            Description = $"{Name} is {Age} year(s) old.";
        }

        public void GetsOlder()
        {
            Age++;
        }

        public void MakesNoise() { }
    }
}
