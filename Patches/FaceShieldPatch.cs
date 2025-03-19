using System.Reflection;
using SPT.Reflection.Patching;
using UnityEngine;

namespace CleanFaceShields.Patches;

internal class FaceShieldPatch : ModulePatch
{
    protected override MethodBase GetTargetMethod()
    {
        return typeof(VisorEffect).GetMethod(
            "method_2",
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
    }

    [PatchPrefix]
    static bool Prefix(VisorEffect __instance)
    {
        Material material = __instance.method_4();
        material.SetTexture("_GlassDamageTex", __instance.method_0());
        return false;
    }
}
