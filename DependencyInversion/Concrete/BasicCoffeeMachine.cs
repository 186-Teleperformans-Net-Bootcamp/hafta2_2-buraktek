using DependencyInversion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Concrete
{
    public class BasicCoffeeMachine : ICoffee
    {
        public void DoCaffeCrema()
        {
            Console.WriteLine("Caffe Crema is ready!");
        }

        public void DoCoffee()
        {
            Console.WriteLine("Coffee is ready!");
        }

        public void DoEspresso()
        {
            Console.WriteLine("Espresso is ready!");
        }
    }
}
