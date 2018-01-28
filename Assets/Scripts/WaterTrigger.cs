using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour {
    bool collided = false;
    public GameObject magicProbe;
  
    EnergyProbeScript eps;
    // Use this for initialization
    void Start()
    {
        eps = magicProbe.GetComponent<EnergyProbeScript>();
        Debug.Log("wttt");
        Debug.Log(eps.GetMagicType());
    }
   
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collider");
       // Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Equals("magic_probe"))
        {
            Debug.Log("magic watertrigger");
            Debug.Log(eps.GetMagicType());
           // if (eps.GetMagicType().Equals("staff"))
            //{
            if (!collided) {
                collided = true;
                AudioSource audio = GetComponent<AudioSource>();

                audio.Play();
            }
            
            // }
        }
    }

    public bool hasCollided()
    {
        
        return collided;
    }
}
