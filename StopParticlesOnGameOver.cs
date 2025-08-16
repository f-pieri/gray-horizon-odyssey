using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopParticlesOnGameOver : MonoBehaviour
{
    private ParticleSystem[] particleSystems;

    //I'm calling the start function
    private void Start()
    {
        //I'm finding and storing all Particle System components on this GameObject
        particleSystems = GetComponentsInChildren<ParticleSystem>();
    }

    //I'm calling the stopparticles function
    public void StopParticles()
    {
        foreach (ParticleSystem ps in particleSystems)
        {
            //I'm stopping the emittion of and clearing all existing particles
            ps.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        }
    }
}
