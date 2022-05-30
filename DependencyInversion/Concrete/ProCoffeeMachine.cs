using DependencyInversion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Concrete
{
    public class ProCoffeeMachine : BasicCoffeeMachine, ICoffeWithMilk
    {
        public void DoCappuccino()
        {
            Console.WriteLine("Cappuccino is ready!");
        }

        public void DoLatte()
        {
            Console.WriteLine("Latte is ready!");
        }

        public void DoLatteMacchiato()
        {
            Console.WriteLine("Latte Macchiato is ready!");
        }
    }
}
