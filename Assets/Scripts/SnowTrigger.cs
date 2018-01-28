using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrigger : MonoBehaviour {
    bool collided = false;
    // Use this for initialization
    void Start () {
		
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
            gameObject.SetActive(false);
        }
    }

    public bool hasCollided()
    {
        
        return collided;
    }
}
