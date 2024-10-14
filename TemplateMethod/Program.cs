using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Beverage tea = new Tea();
            Console.WriteLine("Приготовление чая:");
            tea.PrepareRecipe();

            Console.WriteLine();

            Beverage coffee = new Coffee();
            Console.WriteLine("Приготовление кофе:");
            coffee.PrepareRecipe();

            Console.WriteLine();

            Beverage hotChocolate = new HotChocolate();
            Console.WriteLine("Приготовление горячего шоколада:");
            hotChocolate.PrepareRecipe();
        }
    }

}
