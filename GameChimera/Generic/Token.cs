using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameChimera.Generic
{
    public class TokenValue: IToken
    {
        public Point position
        { get; set; }

        public int X => position.X;
        public int Y => position.Y;

        public float Value
        {get; set;}
        public TokenValue(Point pos)
        {
            position = pos;
            Value = 0.0f;
        }
        public Token()
        {
            position = new Point(0, 0);
            Value = 0.0f;
        }
        
        public Token(int X, int Y)
        {
            position = new Point(X, Y)
            Value = 0.0f;
        }
    }
}