using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.15f, 0, 0);

        if (transform.position.x > 10.0f)
        {
            Destroy(gameObject);
        }
    }
    private string enemyTag = "Enemy";
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag==enemyTag)
    {
        Destroy(col.gameObject);
        Destroy(this.gameObject);
    }
    }
}
