using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleExperimentSmoke : MonoBehaviour
{
    ParticleSystem myPartical;

    void Start()
    {
        myPartical = GetComponent<ParticleSystem>();
        myPartical.Stop();
        Invoke("PlayParticle",39f);
    }

    void PlayParticle()
    {
        myPartical.Play();
    }
}
