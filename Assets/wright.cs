using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wright : MonoBehaviour {
    
    void Update () {
    float translation = Time.deltaTime * 2;
    transform.Translate(0, translation, 0);
    transform.Translate(0, translation, 0, Space.Self);
        }

}
