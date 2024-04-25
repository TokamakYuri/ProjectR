using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace ProjectR
{
    public class PawnData : IExposable
    {
        public Pawn Pawn = null;

        public bool IsHero = false;
        public bool IsIronMan = false;
        public string HeroOwner = "";
        public bool IsTrueNPC = false;

        public PawnData() { }

        public PawnData(Pawn pawn)
        {
            Pawn = pawn;

        }

        public void ExposeData()
        {
            Scribe_Values.Look(ref IsHero, "IsHero", false, true);
            Scribe_Values.Look(ref IsIronMan, "IsIronMan", false, true);
            Scribe_Values.Look(ref HeroOwner, "HeroOwner", "", true);
            Scribe_Values.Look(ref IsTrueNPC, "IsTrueNPC", false, true);
        }
    }
}
