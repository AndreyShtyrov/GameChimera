using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChimera.Interface
{
    public  interface IAction
    {
        public int Idx
        { get; set; }

        public void Forward();
        public void Backward();
    }
}
