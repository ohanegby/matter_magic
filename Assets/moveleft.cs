using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleft : MonoBehaviour {
    
	void Update () {
        float translation = Time.deltaTime * 2;
        transform.Translate(translation, 0, 0);
        transform.Translate(translation, 0,  0, Space.Self);
    }
}
