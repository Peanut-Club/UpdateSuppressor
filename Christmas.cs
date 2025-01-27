using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Christmas.Scp2536;
using Compendium;
using helpers.Patching;
using InventorySystem.GUI.Descriptions;
using MEC;
using UnityEngine;

namespace UpdateSuppressor {
    public class Christmas {
        private static List<float> EmptyFloatList = new List<float>();

        [Patch(typeof(Scp2536Controller), nameof(Scp2536Controller.TeleportingLogicCoroutine), PatchType.Prefix, "Scp2536Tree suppressor")]
        public static bool AutomaticTeleportationSystem(ref IEnumerator<float> __result) {
            //Plugin.Info($"Aborting Scp2536(Christmas tree) spawning");
            __result = EmptyFloatList.GetEnumerator();
            return false;
        }

        [Patch(typeof(Scp559Cake), nameof(Scp559Cake.Update), PatchType.Prefix, "Scp559Cake suppressor")]
        public static bool CakeUpdate() {
            //Plugin.Info($"Aborting Scp559Cake Updating");
            return false;
        }

        [Patch(typeof(Scp956Pinata), nameof(Scp956Pinata.Update), PatchType.Prefix, "Scp956Pinata suppressor")]
        public static bool PinataUpdate() {
            //Plugin.Info($"Aborting Scp956Pinata Updating");
            return false;
        }

        [Patch(typeof(Snowpile), nameof(Snowpile.Awake), PatchType.Prefix, "Snowpile suppressor Awake")]
        public static bool SnowpileAwake() {
            //Plugin.Info($"Aborting Scp956Pinata Updating");
            return false;
        }

        [Patch(typeof(Snowpile), nameof(Snowpile.Update), PatchType.Prefix, "Snowpile suppressor Update")]
        public static bool SnowpileUpdate() {
            //Plugin.Info($"Aborting Scp956Pinata Updating");
            return false;
        }
    }
}
