using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameChimera.Interface;
using GameChimera.Generic;
using GameChimera.Fields;

namespace GameChimera.GameLogic
{
    public class BattleMapLogic
    {
        private BattleMap map;
        public List<IToken> WalkArea(IToken unit)
        {
            var area = new List<TokenValue>() { new TokenValue(unit.X, unit.Y) };
            var areaArray = new TokenValue[map.Horizontal, map.Vertical];
            while (area.Count != 0)
            {
                var newArea = new List<TokenValue>();
                foreach(var token in area)
                {
                    var foundToken = step(new TokenValue(token.X + 1, token.Y), token, areaArray);
                    if (foundToken != null)
                    {
                        newArea.Add(foundToken);
                        areaArray[foundToken.X, foundToken.Y] = foundToken;
                    }
                    foundToken = step(new TokenValue(token.X - 1, token.Y), token, areaArray);
                    if (foundToken != null)
                    {
                        newArea.Add(foundToken);
                        areaArray[foundToken.X, foundToken.Y] = foundToken;
                    }
                    foundToken = step(new TokenValue(token.X, token.Y + 1), token, areaArray);
                    if (foundToken != null)
                    {
                        newArea.Add(foundToken);
                        areaArray[foundToken.X, foundToken.Y] = foundToken;
                    }
                    foundToken = step(new TokenValue(token.X, token.Y - 1), token, areaArray);
                    if (foundToken != null)
                    {
                        newArea.Add(foundToken);
                        areaArray[foundToken.X, foundToken.Y] = foundToken;
                    }
                }
                area = newArea;
            }
            var result = new List<IToken>();
            for(int i = 0; i < map.Horizontal; i++)
                for(int j = 0; j < map.Vertical; j++)
                    if (areaArray[i, j] != null)
                        result.Add(areaArray[i,j]);
            return result;
        }
        private TokenValue step(TokenValue newToken, TokenValue token ,TokenValue[,] areaArray)
        {
            var value = EvaluateStep(token, newToken);
            TokenValue resultToken = null;
            if (areaArray[newToken.X, newToken.Y] == null)
                resultToken = new TokenValue(newToken.X, newToken.Y, value);
            else
            {
                if (value > areaArray[newToken.X, newToken.Y].Value)
                {
                    areaArray[newToken.X, newToken.Y].Value = value;
                    resultToken = areaArray[newToken.X, newToken.Y];
                }
            }
            return resultToken;
        }
        public float EvaluateStep(TokenValue startPosition, TokenValue newPosition)
        {
            return startPosition.Value - 1.0f;
        }
    }
}