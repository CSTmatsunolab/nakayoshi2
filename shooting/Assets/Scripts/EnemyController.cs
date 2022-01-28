using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject scoreObject;

    // Start is called before the first frame update
    void Start()
    {
        scoreObject = GameObject.Find("GameObject");        
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
    private string BulletTag = "Bullet";
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag==BulletTag)
    {
        scoreObject.GetComponent<CountText>().AddScore();
        Destroy(col.gameObject);//これで消えてる
        Destroy(this.gameObject);
    }
    }
}
