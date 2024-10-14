using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class Tea : Beverage
    {
        private bool hasMilk = true;
        protected override void Brew()
        {
            Console.WriteLine("Завариваем листья чая.");
        }
        protected override void AddCondiments()
        {
            if (hasMilk)
            {
                Console.WriteLine("Добавляем молоко.");
            }
            else
            {
                Console.WriteLine("Не хватает ингридиента - молока.");
            }
        }
    }
}
