using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    public float speed = 1000000000000f;

    // Update is called once per frame
    void Update () {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
