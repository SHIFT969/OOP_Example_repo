using System;

namespace OOP_Example
{
    class Cat : Animal
    {
        private Random rand = new Random();
        public override void Voice()
        {
            base.Voice();
            Console.WriteLine(GetRandomVoice());
        }

        // Инкапсуляция - "снаружи" класса не видно каким методом выводится рандомный голос
        private string GetRandomVoice()
        {
            if (rand.Next(2) == 0)
                return "Мяу!";
            else
                return "Мурррррр";
        }
    }
}
