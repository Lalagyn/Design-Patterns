using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    public abstract class Hero
    {
        public abstract string GetDescription();
        public abstract int GetPower();
    }

    public class Warrior : Hero
    {
        public override string GetDescription()
        {
            return "Warrior";
        }

        public override int GetPower()
        {
            return 10;
        }
    }

    public class Mage : Hero
    {
        public override string GetDescription()
        {
            return "Mage";
        }

        public override int GetPower()
        {
            return 8;
        }
    }

    public class Palladin : Hero
    {
        public override string GetDescription()
        {
            return "Palladin";
        }

        public override int GetPower()
        {
            return 12;
        }
    }
}
