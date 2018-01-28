using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour {
    public GameObject player;
    PlayerControl playerControl;
	// Use this for initialization
	void Start () {
        playerControl = player.GetComponent<PlayerControl>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            gameObject.SetActive(false);
            playerControl.PickedDiamond();
            
        }
    }
}
