using System;
using System.Drawing;

namespace OOP_Example
{
    // базовый класс
    class Animal
    {
        // свойства будут унаследованы дочерними классами (Наследование)
        // также свойства являются примером Инкапсуляции - за каждым свойством звкреплено резервное поле
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Breed { get; set; }
        public Color HairColor { get; set; }

        // virtual - можно перезаписать
        // Полиморфизм - все дочерние классы могут использовать базовый метод
        // + Наследование
        public virtual void Voice()
        {
            Console.Write($"{Breed}: ");
        }
    }
}
