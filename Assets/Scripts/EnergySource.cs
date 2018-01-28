using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnergySource : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("trigger!!!");

        ExecuteEvents.Execute<IMagicSourceEvent>(other.gameObject, null, (x, y) => x.MagicSourceEnergy());
    }

    private void OnTriggerExit(Collider other)
    {
        ExecuteEvents.Execute<IMagicSourceEvent>(other.gameObject, null, (x, y) => x.MagicSourceEnergyExit());
    }
}
