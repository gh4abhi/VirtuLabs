using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleExperimentSmoke : MonoBehaviour
{
    // Start is called before the first frame update

    ParticleSystem myPartical;
    void Start()
    {
        myPartical = GetComponent<ParticleSystem>();
        myPartical.Stop();
        Invoke("PlayParticle",39f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayParticle()
    {
        myPartical.Play();
    }
}
