using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (NeedCondiments())
            {
                AddCondiments();
            }
        }
        private void BoilWater()
        {
            Console.WriteLine("Кипятим воду.");
        }
        private void PourInCup()
        {
            Console.WriteLine("Наливаем в кружку.");
        }
        protected abstract void Brew();
        protected abstract void AddCondiments();
        protected virtual bool NeedCondiments() { return true; }
    }
}
