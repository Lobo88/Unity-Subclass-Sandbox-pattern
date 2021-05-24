using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace SubclassSandbox
{
    public class GameController : MonoBehaviour
    {
        
        List<SuperPower> superPowers = new List<SuperPower>();

        void Start()
        {
            
            superPowers.Add(new SkyLaunch());
            superPowers.Add(new GroundDive());
        }

        public bool NamePower(SuperPower power, string name)
        {
            
            if (power.name.Equals("Dive"))
            {
                return true;
            }
            else return false; ;
        }
        public void findPower()
        {

            var item = superPowers.Find(x => x.name == "Dive");
            // if (item == null)
            //   throw new Exception();
           // Debug.Log(item+"lokalizacja");
        }

        void Update()
        {
         

            findPower();
            for (int i = 0; i < superPowers.Count; i++)
                {
             
                superPowers[i].Activate();
                if (NamePower(superPowers[i], superPowers[i].name)==true) {
                  //  Debug.Log("super power znaleziony");
                };
                }
            
        }
    }
}