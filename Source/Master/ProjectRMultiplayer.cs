using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;
using Multiplayer;
using Multiplayer.API;

namespace ProjectR
{
    [StaticConstructorOnStartup]
    public static class ProjectRMultiplayer
    {
        static ProjectRMultiplayer()
        {
            if (!MP.enabled) { return; }

            MP.RegisterAll();
        }
    }
}
