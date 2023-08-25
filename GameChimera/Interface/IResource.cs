using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChimera.Interface
{
    public interface IResource
    {
        public ResourceType Type { get; }

        public void Spend();
        public void Retain();
    }

    public enum ResourceType
    {
        None = 0,
        MovePoint = 1,
        AtackPoint = 2,
        SupplyPoint = 3,
        ManaPoint = 4,
        SkillPoint = 5,
    }
}
