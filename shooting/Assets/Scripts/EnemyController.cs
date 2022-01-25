using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.05f, 0, 0);

        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }
        //当たり判定はここで管理した方がいいんじゃ
    }
}
