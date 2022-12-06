using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using KSP.UI.Screens;


namespace PremierModKSP
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class firstTest : MonoBehaviour
    {
        private const string Path = "D:/jeux/steam/steamapps/common/Kerbal Space Program/modding/PremierModKSP/PremierModKSP/";
        private const string Name = "MJ2.png";

        ApplicationLauncher applicationLauncher;
        ApplicationLauncherButton applicationLauncherButton;
        public void Start()
        {
            Debug.Log(ApplicationLauncher.Instance);
            applicationLauncher = ApplicationLauncher.Instance;
            Texture2D tex = new Texture2D(38, 38);

            applicationLauncherButton = applicationLauncher.AddModApplication(OnTrue,
            OnFalse,
            null,
            null,
            null,
            null,
            ApplicationLauncher.AppScenes.FLIGHT,
            tex);
        }

        public void OnTrue()
        {
            Debug.Log("Oppened");
        }
        public void OnFalse()
        {
            Debug.Log("Closed");
        }
    }
}