using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class HeartOfTheDragoon : RecordMateria
    {
        public override uint RecordMaterId { get { return 111040030; } }
        public override string Name { get { return "Heart of the Dragoon"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Name == "Sky Grinder" ||
                ability.Name == "High Jump" ||
                ability.Name == "Double Jump" ||
                ability.Name == "Gungnir" ||
                ability.Name == "Rising Drive" ||
                ability.Name == "Death Claw" ||
                ability.Name == "Repentance" ||
                ability.Name == "Boost Jump" ||
                ability.Name == "Hyper Jump" ||
                ability.Name == "Dragon Breath" ||
                ability.Name == "Jump" ||
                ability.Name == "Wind Jump" ||
                ability.Name == "Ice Jump" ||
                ability.Name == "Lightning Jump" ||
                ability.Name == "Soaring Jump" ||
                ability.Name == "Leeching Leap"
                )
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
