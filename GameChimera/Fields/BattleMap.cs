using System.Diagnostics;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameChimera;
using GameChimera.Fields;
using System.Drawing;
using GameChimera.Interface;
using GameChimera.Generic;

namespace GameChimera.Fields
{
    public class BattleMap
    {
        public BattleMapUnitLevel GroundUnits
        {get;}
        public BattleMapUnitLevel FlyingUnits
        {get;}
        public BattleMapFieldLevel GroundField
        {get;}
        public BattleMapUnitLevel Triggers
        {get; }

        public BattleMapUnitLevel Buildings 
        {get; }
        public string Name 
        {get; set;}

        public int Horizontal
        {get; }

        public int Vertical
        { get; }

        public BattleMap(int horizontalSize, int verticalSize)
        {
            GroundField = new BattleMapFieldLevel("GroundField", horizontalSize, verticalSize);
            Triggers = new BattleMapUnitLevel("GroundField", LevelType.Unvisible);
            Name = "New Map";
            FlyingUnits = new BattleMapUnitLevel("GroundField", LevelType.Visible);
            GroundUnits = new BattleMapUnitLevel("GroundField", LevelType.Visible);
            Buildings = new BattleMapUnitLevel("GroundField", LevelType.Visible);
            Horizontal = horizontalSize;
            Vertical = verticalSize;
        }

        public static BattleMap Load(string file)
        {
            throw new NotImplementedException();
        }

        public void Save(string file)
        {

        }
        public static BattleMap InitFromPreset(string data)
        {
            throw new NotImplementedException();
        }

        public bool CheckPositinInBorders(Point pos)
        {
            if ( pos.X < 0 || Horizontal < pos.X)
                return false;
            if (pos.Y < 0 || Vertical < pos.Y)
                return false;
            return true;
        }

    }
}