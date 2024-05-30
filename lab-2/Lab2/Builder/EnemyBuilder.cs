using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character;

        public EnemyBuilder()
        {
            _character = new Character();
        }

        public ICharacterBuilder SetHeight(double height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBodyType(string bodyType)
        {
            _character.BodyType = bodyType;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            _character.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder AddInventoryItem(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
}
