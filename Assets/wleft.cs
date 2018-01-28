using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wleft : MonoBehaviour
{

    public float Showtime = 0f;
    public int counter = 7;

    void Update()
    {
        if (counter > 0)
        {
            Showtime = 5f;
            counter = counter - 1;
        }
        if (Showtime > 0f)
        {

                Showtime = Showtime - (Time.deltaTime);
                float translation = Time.deltaTime * 2;
                transform.Translate(0, -translation, 0);
                transform.Translate(0, -translation, 0, Space.Self);
        }
    }
}
