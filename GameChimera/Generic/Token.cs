using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using GameChimera.Interface; 

namespace GameChimera.Generic
{
    public class TokenValue: IToken
    {
        public Point Position
        { get; set; }

        public int X => Position.X;
        public int Y => Position.Y;

        public float Value
        {get; set;}
        public TokenValue(Point pos)
        {
            Position = pos;
            Value = 0.0f;
        }
        public TokenValue()
        {
            Position = new Point(0, 0);
            Value = 0.0f;
        }
        
        public TokenValue(int X, int Y)
        {
            Position = new Point(X, Y);
            Value = 0.0f;
        }
        public TokenValue(int X, int Y, float value)
        {
            Position = new Point(X, Y);
            Value = value;
        }
    }
}