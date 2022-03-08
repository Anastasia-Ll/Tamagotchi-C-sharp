using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_9
{
    class Cat
    {
        public string Name { get; set; }
        public int live;
        public string color;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как зовут кота?");
            Cat cat = new Cat() { Name = Convert.ToString(Console.ReadLine()), live = 5, color = "жёлтый" };

            if (cat.live < 3)
                cat.color = "красный";
            else if (cat.live > 5)
                cat.color = "зелёный";
            else cat.color = "жёлтый";

            Console.WriteLine("Для того, чтобы покормить кота нажмите 1 \nДля того, чтобы наказать кота нажмите 2 \nДля того, чтобы узнать о текущем здоровье кота нажмите любую клавишу");
           
            while (cat.live > -1)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                    cat.live++;
                else if (k == 2)
                    cat.live--;
                else Console.WriteLine("Здоровье " + cat.Name + " = " + cat.live + "\nОкрас " + cat.Name + ": " + cat.color);
            }
            Console.WriteLine(cat.Name + " мёртв :(");
            Console.ReadKey();
        }
    }
}
