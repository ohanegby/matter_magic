using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mountainDown : MonoBehaviour
{

    public float Showtime = 0f;
    public int counter = 7;
    //public GameObject snowCollider;
    //WaterTrigger waterTrigger;

    void Start()
    {
        //waterTrigger = waterCollider.GetComponent<WaterTrigger>();
    }

    void Update()
    {
        if (counter > 0) //&& waterTrigger.hasCollided()
        {
            Showtime = 7f;
            counter = counter - 1;
        }
        if (Showtime > 0f)
        {
            Showtime = Showtime - (Time.deltaTime);
            float translation = Time.deltaTime * 5;
            transform.Translate(0, -translation, 0);
            transform.Translate(0, -translation, 0, Space.Self);
        }

    }
}