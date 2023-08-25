using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace GameChimera.Interface
{
    public interface IToken
    {
        public Point Position
        {get; set;}

        public int X
        { get; }

        public int Y
        { get; }
    }
}