using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrigger : MonoBehaviour {
    bool collided = false;
    public GameObject diamond;
    public GameObject magicProbe;
    DiamondScript diamondScript;
    EnergyProbeScript eps;
    // Use this for initialization
    void Start () {
        diamondScript = diamond.GetComponent<DiamondScript>();
        eps = magicProbe.GetComponent<EnergyProbeScript>();
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
            //if (eps.GetMagicType().Equals("lava"))
            //{
                collided = true;
                gameObject.SetActive(false);
                diamondScript.canPick = true;
            //}
        }
    }

    public bool hasCollided()
    {
        
        return collided;
    }
}
