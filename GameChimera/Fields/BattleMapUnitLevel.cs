using GameChimera.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Godot;
using GameChimera.Generic;

namespace GameChimera.Fields
{
   
    public class BattleMapUnitLevel: ILevel<BattleMapUnit>
    {
        
        public string Name
        {get; }

        public List<BattleMapUnit> Objects
        { get; }

        public LevelType type => throw new NotImplementedException();

        public BattleMapUnitLevel(string Name, LevelType type)
        {
            Objects = new List<BattleMapUnit>();
            this.Name = Name;
        }

        public bool CheckIsUnitInPosition(Point pos)
        {
            foreach(var unit in Objects)
            {
                if (unit.Position == pos)
                    return true;
            }
            return false;
        }

        public BattleMapUnit GetObjectByPosition(Point pos)
        {
            foreach(var unit in Objects)
            {
                if (unit.Position == pos)
                    return unit;
            }
            throw new  Exception() ;
        }

        public void AddObject(BattleMapUnit unit)
        {
            Objects.Add(unit);
            unit.Parent = this;
        }

        public void RemoveObjectByPosition(Point pos)
        {
            foreach(var unit in Objects)
            {
                if (unit.Position == pos)
                {
                    Objects.Remove(unit);
                    unit.Remove();
                }
            }
        }
    }
}
