using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour, IMagicSourceEvent
{
    public GameObject rightHand;
    public GameObject leftHand;
    public GameObject probe;
    public GameObject magicProbe;
    public GameObject magicParticles;
    public GameObject magicBeam;
 
    bool isThumbPressed = false;
    bool magicMode = false;
    Vector3 thumbStart;
    public float playerHeight = 10.0f;
    int diamondCount = 0;
	// Use this for initialization
	void Start () {
        
        
	}

    void updateMagicProbe()
    {
        Vector3 dirVec = leftHand.transform.position - this.transform.position;
        float distance = -leftHand.transform.localRotation.x;

        distance = Mathf.Max(distance, 5);
        //distance = Mathf.Min(distance, 10);
        //Debug.Log(distance);
    
        RaycastHit hit;

        Vector3 forwardVector = leftHand.transform.rotation * Vector3.forward;

        bool haveHit = false;
        //probe.transform.position = rayStart + forwardVector * 20.0f;
        if (Physics.Raycast(leftHand.transform.position, forwardVector, out hit))
        {
            haveHit = true;
            Rigidbody rb = magicProbe.GetComponent<Rigidbody>();
            //magicProbe.transform.position = leftHand.transform.position + forwardVector * hit.distance * 0.9f;
            rb.MovePosition(leftHand.transform.position + forwardVector * hit.distance * 0.9f);
        }
    }

	
	// Update is called once per frame
	void Update () {
        if (magicMode)
        {
           
            OVRInput.SetControllerVibration(3, 3, OVRInput.Controller.LTouch);
            updateMagicProbe();
        }
        Vector2 axisVecs = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        Vector2 touchAxis = axisVecs * Time.deltaTime;
        if (touchAxis.x != 0)
        {
            if (!isThumbPressed)
            {
                isThumbPressed = true;
                thumbStart = rightHand.transform.position;
            }
           // Debug.Log(touchAxis.x);
            Vector3 dirVec = rightHand.transform.position - this.transform.position;
            float distance = -rightHand.transform.localRotation.x;
           
            distance = Mathf.Max(distance, 5);
            //distance = Mathf.Min(distance, 10);
            //Debug.Log(distance);
            Vector3 normVec = dirVec.normalized * distance;
            Vector3 rayStart = normVec + this.transform.position + new Vector3(0,200.0f,0);
            
            RaycastHit hit;

            Vector3 forwardVector = rightHand.transform.rotation * Vector3.forward;
            Debug.Log(forwardVector);
            bool haveHit = false;
            rayStart = rightHand.transform.position;
            //probe.transform.position = rayStart + forwardVector * 20.0f;
            if (Physics.Raycast(rightHand.transform.position, forwardVector, out hit))
            {
                haveHit = true;
                rayStart.y = rayStart.y - hit.distance;
                probe.transform.position = rightHand.transform.position + forwardVector * hit.distance * 0.9f;
            }
        } else
        {
            if (isThumbPressed)
            {
                isThumbPressed = false;
                Vector3 posFix = new Vector3(probe.transform.position.x, transform.position.y, probe.transform.position.z);
                Vector3 relativePos = posFix - transform.position;
                Quaternion rotation = Quaternion.LookRotation(relativePos);
                transform.position = probe.transform.position + new Vector3(0, playerHeight,0);
                transform.rotation = rotation;
                
            }
        }
      //  transform.position += new Vector3(touchAxis.x, 0, touchAxis.y);
    }

    public void MagicSourceEnergy()
    {
        magicParticles.SetActive(true);
        magicBeam.SetActive(true);
        magicProbe.SetActive(true);
        OVRInput.SetControllerVibration(10, 10, OVRInput.Controller.RTouch);
        magicMode = true;
    }

    public void MagicSourceEnergyExit()
    {
        magicParticles.SetActive(false);
        magicBeam.SetActive(false);
        magicProbe.SetActive(false);
        OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
        magicMode = false;
    }

    public void PickedDiamond()
    {
        diamondCount++;
    }
}
