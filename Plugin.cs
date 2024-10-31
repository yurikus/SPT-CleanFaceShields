using BepInEx;
using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanFaceShields.Patches;
using BepInEx.Configuration;

namespace CleanFaceShields
{
    [BepInPlugin("com.penguingreentea.CleanFaceShields", "CleanFaceShields", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static ManualLogSource LogSource;

        private void Awake()
        {
            LogSource = Logger;
            new FaceShieldPatch().Enable();
        }
    }
}
