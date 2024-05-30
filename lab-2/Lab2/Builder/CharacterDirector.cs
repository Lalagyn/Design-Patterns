using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CharacterDirector
    {
        private ICharacterBuilder _builder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public Character ConstructHero()
        {
            return _builder
                .SetHeight(150)
                .SetBodyType("Варвар")
                .SetHairColor("Блондин")
                .SetEyeColor("Жовтий")
                .SetClothing("Лицарські обладунки")
                .AddInventoryItem("Меч")
                .AddInventoryItem("Щит")
                .Build();
        }

        public Character ConstructEnemy()
        {
            return _builder
                .SetHeight(140)
                .SetBodyType("Лучница")
                .SetHairColor("Розовий")
                .SetEyeColor("Червоні")
                .SetClothing("Лучниця мантія")
                .AddInventoryItem("Лук")
                .AddInventoryItem("Вогняні стріли")
                .Build();
        }
    }
}
