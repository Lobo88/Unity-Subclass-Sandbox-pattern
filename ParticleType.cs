using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleType
{
    // w particlu definiujemy czas jego trwania 
    public virtual void GetParticles(string typOfParticle) { Debug.Log("Start typ particle odtwarzanie efektu " + typOfParticle); }
    public virtual void stopParticle(string typOfParticle) { Debug.Log("stop particle" + typOfParticle); }

}
public class NullParticle : ParticleType
{

    public override  void GetParticles(string typOfParticle) { typOfParticle= null; }
    public override void stopParticle(string typOfParticle) { typOfParticle = null; }
}
