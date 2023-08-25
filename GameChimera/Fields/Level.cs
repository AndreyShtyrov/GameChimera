using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameChimera.Fields
{
    public class Level: ILevel
    {
        public string Name
        {get; }
        public List<IGameObjects> Objects
        { get; }
        
        public Level(string Name, LevelTypes type)
        {
            Objects = new List<IGameObjects>();
        }

        public bool CheckIsUnitInPosition(Point pos)
        {
            foreach(var unit in Objects)
            {
                if (unit.position == pos)
                    return true;
            }
            return false;
        }

        public IGameObject GetObjectByPosition(Point pos)
        {
            foreach(var unit in Objects)
            {
                if (unit.position == pos)
                    return unit;
            }
            throw ;
        }

        public void AddObject(IGameObject unit)
        {
            Objects.Add(unit);
            unit.parent = this;
        }

        public void RemoveObjectByPosition(Point pos)
        {
            foreach(var unit in Objects)
            {
                if (unit.position == pos)
                {
                    Objects.Remove(unit);
                    unit.Remove();
                }
            }
        }
    }
}
