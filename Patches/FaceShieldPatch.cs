using EFT;
using EFT.Ballistics;
using EFT.CameraControl;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using HarmonyLib;
using SPT.Reflection.Patching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using static Val;

namespace CleanFaceShields.Patches
{

    internal class FaceShieldPatch : ModulePatch
    {

        protected override MethodBase GetTargetMethod()
        {
            return typeof(VisorEffect).GetMethod("method_2", BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
        }

        [PatchPrefix]
        static bool Prefix(VisorEffect __instance)
        {

            Material material = __instance.method_4();
            material.SetTexture("_GlassDamageTex", __instance.method_0());
            return false;
            
        }

    }
}
