using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject scoreObject;
    public GameObject Enemytama;
    Vector3 pos;
    Transform myTransform;
    // Start is called before the first frame update
    float span = 0.8f;
    float delta = 0;
    

    void Start()
    {
        scoreObject = GameObject.Find("GameObject");        
    }


    // public bool Flag{
    // get{ return this.flag; }  //取得用
    // private set{ this.flag = value; }　//値入力用
    // }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.10f, 0, 0);

        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }
        //当たり判定はここで管理した方がいいんじゃ
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
             this.delta = 0;
             myTransform = this.transform;
             pos = myTransform.position;
             pos.x += 1.5f;
             pos.y -= 0.27f;
             Instantiate(Enemytama, pos, Quaternion.identity);
        }
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
