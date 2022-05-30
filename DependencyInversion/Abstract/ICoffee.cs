using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Abstract
{
    internal interface ICoffee
    {
        public void DoEspresso();
        public void DoCaffeCrema();
        public void DoCoffee();
    }
}
