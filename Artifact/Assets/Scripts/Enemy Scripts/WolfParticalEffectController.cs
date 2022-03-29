using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfParticalEffectController : MonoBehaviour
{
    [SerializeField]
    GameObject deathParticlePrefab;

    void OnEnable()
    {
        gameObject.GetComponent<WolfHealth>().OnDeath += CreateDeathParticle;
    }

    void OnDisable()
    {
        gameObject.GetComponent<WolfHealth>().OnDeath -= CreateDeathParticle;
    }


    void CreateDeathParticle()
    {
        Instantiate(deathParticlePrefab, transform.position,transform.rotation);

    }

    
}
