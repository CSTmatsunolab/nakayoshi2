using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float x;
    //float speed = 0;

    void Update()
    {
        //this speed = 0.2f;
        this.transform.Translate(-x, 0, 0);
        if (transform.position.x < -10.0f)
        { 
            Destroy(this.gameObject);
        }

    }
}
