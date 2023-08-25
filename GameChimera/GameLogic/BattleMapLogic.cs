using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameChimera.GameLogic
{
    public class BattleMapLogic
    {
        private BattleMap map;
        
        public List<Token> WalkArea(IGameObject unit)
        {
            var area = new List<TokenValue>();
            var areaArray = new TokenValue[map.Horizontal, map.Vertical]();
            bool canMove = true;
            while (canMove)
            {
                foreach(var token in area)
                {
                    var newToken = new TokenValue(token.X + 1, token.Y);
                    area = step(newToken, token, area);
                    newToken = new TokenValue(token.X - 1, token.Y);
                    area = step(newToken, token, area);
                    area = step(new TokenValue(token.X, token.Y + 1), token, area);
                    area = step(new TokenValue(token.X, token.Y - 1), token, area);
                }
            }
            var result = new List<IToken>();
            for(int i; i < map.Horizontal; i++)
                for(int j; j < map.Vertical; j++)
                    if (area[i, j] != null)
                        result.Add(area[i,j]);
            return result;
        }
        private TokenValue[,] step(TokenValue newToken, TokenValue token ,TokenValue[,] area)
        {
                    var value = EvaluateStep(token, newToken)
                    if (areaArray[newToken.X, newToke.Y] == null)
                        {
                            newToken.Value = value;
                            areaArray[newToken.X, newToken.Y] = newToken;
                        }
                    else
                    {
                        if (value > areaArray[newToken.X, newToken.Y])
                            areaArray[newToken.X, newToken.Y] = value;
                    }
                    return area;
        }

        public float EvaluateStep(TokenValue startPosition, int newPosition)
        {
            return startPosition.Value - 1.0f;
        }
    }
}