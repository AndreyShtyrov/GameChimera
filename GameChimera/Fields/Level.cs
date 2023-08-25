using GameChimera.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace GameChimera.Fields
{
    public class Level: ILevel
    {
        public string Name
        {get; }
        public List<IGameObject> Objects
        { get; }

        public List<IGameObject> objects => throw new NotImplementedException();

        public LevelType type => throw new NotImplementedException();

        public Level(string Name, LevelType type)
        {
            Objects = new List<IGameObject>();
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

        public IGameObject GetObjectByPosition(Point pos)
        {
            foreach(var unit in Objects)
            {
                if (unit.Position == pos)
                    return unit;
            }
            throw new  Exception() ;
        }

        public void AddObject(IGameObject unit)
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
