﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class ConfuseShell : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30261041; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Machinist; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.9; } }
        public override string Name { get { return "Confuse Shell"; } }
        public override int Rarity { get { return 4; } }
    }
}
