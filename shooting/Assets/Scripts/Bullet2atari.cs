using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2atari : MonoBehaviour
{
    public GameObject Range;
    private string enemyTag = "Enemy";
    public float x;
    //float speed = 0;

    void Update()
    {
        //this speed = 0.2f;
        this.transform.Translate(-0.1f, 0, 0);
        Destroy(Range,4);
    }
   /* private string enemyTag = "Enemy";
    void OnCollisionEnter2D(Collision2D col)
    {
    if (col.collider.tag == enemyTag)
    {
        Destroy(col.gameObject);
        Destroy(this.gameObject);
    }
    }*/
    void OnTriggerEnter2D(Collider2D col)
    {
    if (col.tag==enemyTag)
    {
        Destroy(col.gameObject);
        Destroy(this.gameObject);
    }
    }
}
