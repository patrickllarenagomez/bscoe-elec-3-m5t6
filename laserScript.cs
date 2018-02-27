using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserScript : MonoBehaviour {

    // Use this for initialization
    ParticleSystem particleSystem;
	void Start () {

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnParticleCollision(GameObject other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            particleSystem = other.GetComponentInChildren<ParticleSystem>();
            particleSystem.Play();


            Destroy(other, .1f);
            Destroy(other.transform.parent.gameObject, .1f);


        }
    }
}
