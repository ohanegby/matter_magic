using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public GameObject rightHand;
    public GameObject probe;
    bool isThumbPressed = false;
    Vector3 thumbStart;
	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 touchAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick) * Time.deltaTime;
        if (touchAxis.x != 0)
        {
            if (!isThumbPressed)
            {
                isThumbPressed = true;
                thumbStart = rightHand.transform.position;
            }
           // Debug.Log(touchAxis.x);
            Vector3 dirVec = rightHand.transform.position - this.transform.position;
            float distance = Mathf.Max(rightHand.transform.position.y - thumbStart.y, 0) * 50;
            distance = Mathf.Max(distance, 3);
            distance = Mathf.Min(distance, 10);
            Debug.Log(distance);
            Vector3 normVec = dirVec.normalized * 10;
            Vector3 rayStart = normVec + this.transform.position;
            RaycastHit hit;

            if (Physics.Raycast(transform.position, dirVec.normalized, out hit))
            {
                probe.transform.position = probe.transform.position + dirVec.normalized * hit.distance;
            } else if (Physics.Raycast(rayStart, -Vector3.up, out hit))
            {
                rayStart.y = rayStart.y - hit.distance;
                probe.transform.position = rayStart;
            }
        } else
        {
            if (isThumbPressed)
            {
                isThumbPressed = false;
                Vector3 posFix = new Vector3(probe.transform.position.x, transform.position.y, probe.transform.position.z);
                Vector3 relativePos = posFix - transform.position;
                Quaternion rotation = Quaternion.LookRotation(relativePos);
                transform.position = probe.transform.position;
                transform.rotation = rotation;
                
            }
        }
      //  transform.position += new Vector3(touchAxis.x, 0, touchAxis.y);
    }
}
