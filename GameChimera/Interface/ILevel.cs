using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameChimera.Interface;

namespace GameChimera.Interface
{
    public enum LevelType {
        Visible = 0,
        Unvisible = 1,
    }

    public interface ILevel<T>
        where T : IToken
    {
        public List<T> Objects
        {get;}

        public string Name {get;}

        public LevelType type {get;}

        
    }
}