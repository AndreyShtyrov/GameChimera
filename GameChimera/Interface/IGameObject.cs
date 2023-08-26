using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameChimera.Interface;

namespace GameChimera.Interface
{
    public interface IGameObject: IToken
    {
        public int index
        {get; }

        public void Remove();
    }
}