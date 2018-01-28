using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour {
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
        if (other.gameObject.name.Equals("magic_probe"))
        {
            collided = true;
        }
    }

    public bool hasCollided()
    {
        
        return collided;
    }
}
