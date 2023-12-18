using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using LCFirstMod.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCFirstMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class FirstModBase : BaseUnityPlugin
    {
        private const string modGUID = "Poseidon.LCFirstMod";
        private const string modName = "LCFirstmod";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static FirstModBase Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
             
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("The bbc mod has awaken (hope you have fun) :)");

            harmony.PatchAll(typeof(FirstModBase));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }

    }
}
