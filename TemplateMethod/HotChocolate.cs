using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class HotChocolate : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Заливаем кипятком несколько ломтиков шоколада.");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Какое желаете молоко?(1 - коровье, 2 - кокосовое, 3 - миндальное)");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Добавляем коровье молоко.");
                    break;
                case 2:
                    Console.WriteLine("Добавляем кокосовое молоко.");
                    break;
                case 3:
                    Console.WriteLine("Добавляем миндальное молоко.");
                    break;
                default:
                    break;
            }
        }
    }
}
