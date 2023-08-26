using GameChimera.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChimera.Generic
{
    public class FieldToken : IToken
    {
        public string Name { get; set; }

        public Point Position { get; set; }

        public int X => Position.X;

        public int Y => Position.Y;
        
        public FieldToken(string name, Point position) 
        { 
            Name = name;
            Position = position;
        }
    }
}
