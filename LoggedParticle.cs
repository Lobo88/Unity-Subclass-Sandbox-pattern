using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoggedParticle : ParticleType
{
    //private static LoggedParticle wrapper;
    private ParticleType wrapper_ = new ParticleType();
   

    public LoggedParticle(ParticleType wrapper )
    {
        wrapper_= wrapper;
        playParticle(wrapper_);
    }
    private void logi(string message)
        {
        Debug.Log(message);
        }
   public virtual void playParticle(ParticleType wrapp)
    {
        logi("start particle with loggedparticle"+ wrapp);
        //wrapper_.GetParticles("fire");
    }
  
   
}
