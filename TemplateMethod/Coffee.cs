using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем кофе.");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем ложку сахара и молоко.");
        }
        protected override bool NeedCondiments()
        {
            Console.WriteLine("Желаете добавить сахар и молоко?(y/n)");
            return Console.ReadLine().ToLower() == "y";
        }
    }
}
