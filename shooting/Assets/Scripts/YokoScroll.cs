using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class YokoScroll : MonoBehaviour
{
    //スクロールスピード
    [SerializeField] float speed = 2;
   
   void Update()
   {
       //下方向にスクロール
        transform.position -= new Vector3(Time.deltaTime * speed,0);
        
        //Yが-11まで来れば、21.33まで移動する
        if(transform.position.x <= -18.53f){
            transform.position = new Vector2(37.03f,0);
        }
    }
}

