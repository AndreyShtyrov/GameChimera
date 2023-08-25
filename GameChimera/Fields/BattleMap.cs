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

namespace GameChimera.Fields
{
    public class BattleMap
    {
        public Level GroundUnits
        {get;}
        public Level FlyingUnits
        {get;}
        public Level GroundField
        {get;}
        public Level Triggers
        {get; }

        public Level Buildings 
        {get; }
        public string Name 
        {get; set;}

        public int Horizontal
        {get; }

        public int Vertical
        { get; }

        public BattleMap(int horizontalSize, int VerticalSize)
        {
            GroundField = new Level("GroundField", LevelType.Visible);
            Triggers = new Level("GroundField", LevelType.Unvisible);
            Name = "New Map";
            FlyingUnits = new Level("GroundField", LevelType.Visible);
            GroundUnits = new Level("GroundField", LevelType.Visible);
            Buildings = new Level("GroundField", LevelType.Visible);
            Horizontal = horizontalSize;
            Vertical = VerticalSize;
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