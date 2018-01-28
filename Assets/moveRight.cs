using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRight : MonoBehaviour
{

    public float Showtime = 0f;
    public int counter = 7;
    public GameObject waterCollider;
    WaterTrigger waterTrigger;

    void Start()
    {
        waterTrigger = waterCollider.GetComponent<WaterTrigger>();
    }
    void Update()
    {
        if (counter > 0 && waterTrigger.hasCollided())
        {
            Showtime = 7f;
            counter = counter - 1;
        }
        if (Showtime > 0f)
        {
            Showtime = Showtime - (Time.deltaTime);
            float translation = Time.deltaTime * 2;
            transform.Translate(-translation, 0, 0);
            transform.Translate(-translation, 0, 0, Space.Self);
        }

    }
}