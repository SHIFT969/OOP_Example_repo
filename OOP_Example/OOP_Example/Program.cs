using System;
using System.Collections.Generic;
using System.Drawing;

namespace OOP_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> petShop = new List<Animal>();
            petShop.Add(new Cat() { Breed = "Сиамский кот", HairColor = Color.LightYellow, Height = 10.5, Weight = 3.2 });
            petShop.Add(new Dog() { Breed = "Овчарка", HairColor = Color.White, Height = 17.85, Weight = 10 });

            petShop[0].Voice();
            petShop[1].Voice();

            Console.ReadKey();
        }
    }
}
