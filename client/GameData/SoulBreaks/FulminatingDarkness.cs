﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class FulminatingDarkness : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22180003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BASCH; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.35; } }
        public override string Name { get { return "Fulminating Darkness"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
