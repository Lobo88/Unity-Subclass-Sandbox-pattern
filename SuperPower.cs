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
           // Debug.Log("Name power " + name);
            this.name = name;

        }
            protected void Move(float speed)
        {
           // Debug.Log("Moving with speed " + speed);
        }

        protected void PlaySound(string coolSound)
        {
           // Debug.Log("Playing sound " + coolSound);
        }

        protected void SpawnParticles(String type, int count)
        {
            Locator lokator = new Locator();
            ParticleType particle = new LoggedParticle(lokator.StartParticle());
            particle.GetParticles(type);
            lokator.provide(particle);
            //particle.spawn(type, count);
		
        }
        protected void StopParticles(String type, int count)
        { 
            Locator lokator = new Locator();
            ParticleType particle = new LoggedParticle(lokator.StartParticle());
            particle.stopParticle(type);
            lokator.provide(particle);
        }
        }


   
    public class SkyLaunch : SuperPower
    {
        
        public override void Activate()
        {
           
            nameOfPower("jump");
            Move(10f);
            PlaySound("SkyLaunch");
            SpawnParticles("Fire bolt",3);
        }
    }

    public class GroundDive : SuperPower
    {
       
        public override void Activate()
        {
           
            nameOfPower("Dive");
            Move(15f);
            PlaySound("GroundDive");
            //StopParticles("stop bolt",3);
        }
    }
}