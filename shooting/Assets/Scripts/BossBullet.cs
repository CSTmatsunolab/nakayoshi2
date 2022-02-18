using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public float x;
    private GameObject ziki;
    Vector3 diff;
    // Start is called before the firstt frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        ziki = GameObject.Find("ziki");
        diff = Vector3.Normalize(ziki.transform.position - this.transform.position); 
    }

    // Update is called once per frame
    void Update()
    {
         //プレイヤーと対照との差分を取得
        transform.Translate(diff.x * x * 2,diff.y * x * 2,0);
        //ビルド後の速さ
        //transform.position= Vector3.MoveTowards(this.transform.position,ziki.transform.position,x);//取得した座標に対して変数をかけてやると進む
        if (transform.position.x < -10.0f)
        { 
            Destroy(this.gameObject);
        }
    }
}
