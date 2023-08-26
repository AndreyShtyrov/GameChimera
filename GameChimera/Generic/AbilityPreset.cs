using GameChimera.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChimera.Generic
{
    public enum AbilityType
    {
        PreemptiveAttack = 0,
        Attack = 1,
        AfterBattle = 2,
        RangeAttack = 3,
        AttackWithoutResponse = 4,
        Heal = 5,
        ActionWitoutTargetSelect = 6,
        SelectAndAttack = 7,
        Move = 8,
    }

    public abstract class AbilityPresset
    {
        public string Name;
        public AbilityType AbilityType;

        public int idx
        { get; set; }

        private BattleMapUnit unit;

        public int DeafaultRange = 1;
        public int CurrentRange;

        public abstract List<IAction> Use(IToken target);

        public abstract bool IsReadyToUse();

        public abstract void BreakAction();

        public abstract void Return();
    }
}
