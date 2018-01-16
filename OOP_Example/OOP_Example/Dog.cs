using System;

namespace OOP_Example
{
    class Dog : Animal
    {
        public override void Voice()
        {
            base.Voice();
            Console.WriteLine("Гав!");
        }
    }
}
