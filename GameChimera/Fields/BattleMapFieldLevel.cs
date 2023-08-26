using GameChimera.Generic;
using GameChimera.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChimera.Fields
{
    public class BattleMapFieldLevel : ILevel<FieldToken>
    {
        public string Name { get; }

        public int Horizontal { get; }

        public int Vertical { get; }
        public LevelType type { get; }

        public List<FieldToken> Objects { get; }

        public BattleMapFieldLevel(string name, int horizontal, int vertical)
        {
            Name = name;
            Objects = new List<FieldToken>();
            Horizontal = horizontal;
            Vertical = vertical;
        }


    }
}
