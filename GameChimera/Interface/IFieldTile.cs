using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChimera.Interface
{
    public interface IFieldTile
    {
        string Name 
        { get; }
        public (int X, int Y) Position
        { get; }

    }
}
