using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace PremierModKSP
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class firstTest : MonoBehaviour
    {
        public void Update()
        {
            bool key = Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.Alpha1);
            if (key) 
            {
                List<Part> parts = FlightGlobals.ActiveVessel.parts;
                int index;
                System.Random rnd = new System.Random();
                index = rnd.Next(1, parts.Count);
                parts[index].explode();
            }
        }

    }
}