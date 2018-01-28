using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour {
    public GameObject player;
    PlayerControl playerControl;
    public bool canPick = false;
	// Use this for initialization
	void Start () {
        playerControl = player.GetComponent<PlayerControl>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player") && canPick)
        {
            gameObject.SetActive(false);
            playerControl.PickedDiamond();
        }
    }
}
