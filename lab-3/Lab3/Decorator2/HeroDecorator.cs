using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    public abstract class HeroDecorator : Hero
    {
        protected Hero hero;

        public HeroDecorator(Hero hero)
        {
            this.hero = hero;
        }

        public override string GetDescription()
        {
            return hero.GetDescription();
        }

        public override int GetPower()
        {
            return hero.GetPower();
        }
    }

    public class Armor : HeroDecorator
    {
        public Armor(Hero hero) : base(hero) { }

        public override string GetDescription()
        {
            return hero.GetDescription() + ", Броня";
        }

        public override int GetPower()
        {
            return hero.GetPower() + 5;
        }
    }

    public class Weapon : HeroDecorator
    {
        public Weapon(Hero hero) : base(hero) { }

        public override string GetDescription()
        {
            return hero.GetDescription() + ", Зброя";
        }

        public override int GetPower()
        {
            return hero.GetPower() + 7;
        }
    }

    public class Artifact : HeroDecorator
    {
        public Artifact(Hero hero) : base(hero) { }

        public override string GetDescription()
        {
            return hero.GetDescription() + ", Артефакт";
        }

        public override int GetPower()
        {
            return hero.GetPower() + 3;
        }
    }
}
