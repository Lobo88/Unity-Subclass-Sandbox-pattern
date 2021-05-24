using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    static ParticleType service_;
    static NullParticle nullService_;

    public static void initialize()
    {
        service_ = nullService_;
    }
    public ParticleType StartParticle()
    {
        return service_;
    }
    public void provide(ParticleType service)
    {
        if(service == null) { service = nullService_; }
        service_ = service;
    }
}

