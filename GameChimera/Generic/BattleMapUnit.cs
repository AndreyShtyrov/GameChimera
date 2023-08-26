using GameChimera.Fields;
using GameChimera.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChimera.Generic
{
    public class BattleMapUnit : IGameObject
    {
        public Point Position { get; set ; }
        
        public string Name { get; }
        public int X => Position.X;
        public int Y => Position.Y;
        public List<IResource> Resources { get; }

        public List<AbilityPresset> AbilityList { get; }

        public int index { get; }
        public BattleMapUnitLevel<BattleMapUnit> Parent { get; set; }

        public BattleMapUnit(string name, Point position, int index, BattleMapUnitLevel<BattleMapUnit> parent)
        {
            Name = name;
            Position = position;
            this.index = index;
            Parent = parent;
        }

        public void Move(Point position)
        {
            Position = position;
        }
        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
