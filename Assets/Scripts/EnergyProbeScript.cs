using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyProbeScript : MonoBehaviour, IMagicSourceEvent
{
    string magicType = "none";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MagicSourceType(string mType)
    {
        Debug.Log("type update");
        Debug.Log(mType);
        this.magicType = mType;
    }

    public void MagicSourceEnergy()
    {
       
    }

    public void MagicSourceEnergyExit()
    {
        
    }

    public string GetMagicType()
    {
        return magicType;
    }
}
