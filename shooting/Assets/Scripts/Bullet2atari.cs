using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2atari : MonoBehaviour
{
    public GameObject Range;
    public float x;
    //float speed = 0;

    void Update()
    {
        //this speed = 0.2f;
        this.transform.Translate(x * 2, 0, 0);
        Destroy(Range,3);
    }
}
