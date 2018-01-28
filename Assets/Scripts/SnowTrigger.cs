using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrigger : MonoBehaviour {
    bool collided = false;
    public GameObject snowToMelt;
    mountainDown mountain;
    // Use this for initialization
    void Start () {
        mountain = snowToMelt.GetComponent<mountainDown>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collider");
        // Debug.Log(other.gameObject.name);
        Debug.Log("collider_snow");
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Equals("magic_probe"))
        {
            Debug.Log("collider_snow_magic");
            collided = true;
            mountain.shouldMelt = true;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            gameObject.SetActive(false);
        }
    }

    public bool hasCollided()
    {
        
        return collided;
    }
}
