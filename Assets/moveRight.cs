using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRight : MonoBehaviour
{

    public float Showtime = 0f;
    public int counter = 7;

    void Update()
    {
        if (counter > 0)
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