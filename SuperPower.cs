using UnityEngine;
using System.Collections;
using System;

namespace SubclassSandbox
{
   
    public abstract class SuperPower
    {
        public string name { get; set; }
        
        
        public abstract void Activate();

       
        protected void nameOfPower(string name)
        {
            Debug.Log("Name power " + name);
            this.name = name;

        }
            protected void Move(float speed)
        {
            Debug.Log("Moving with speed " + speed);
        }

        protected void PlaySound(string coolSound)
        {
            Debug.Log("Playing sound " + coolSound);
        }

        protected void SpawnParticles()
        {

        }
    }


   
    public class SkyLaunch : SuperPower
    {
        
        public override void Activate()
        {
           
            nameOfPower("jump");
            Move(10f);
            PlaySound("SkyLaunch");
            SpawnParticles();
        }
    }

    public class GroundDive : SuperPower
    {
       
        public override void Activate()
        {
           
            nameOfPower("Dive");
            Move(15f);
            PlaySound("GroundDive");
            SpawnParticles();
        }
    }
}