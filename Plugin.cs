using BepInEx;
using BepInEx.Logging;
using CleanFaceShields.Patches;

namespace CleanFaceShields;

[BepInPlugin("com.penguingreentea.CleanFaceShields", "CleanFaceShields", PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    public const string PluginVersion = "1.0.2.1";

    public static ManualLogSource LogSource;

    private void Awake()
    {
        LogSource = Logger;
        new FaceShieldPatch().Enable();
    }
}
