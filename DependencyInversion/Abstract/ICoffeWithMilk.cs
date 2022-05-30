using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Abstract
{
    internal interface ICoffeWithMilk
    {
        public void DoLatte();
        public void DoCappuccino();
        public void DoLatteMacchiato();

    }
}
