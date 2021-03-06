using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI使うときは忘れずに。
using UnityEngine.UI;

public class BossHPBar : MonoBehaviour
{
    GameObject scoreObject;
    //最大HPと現在のHP。
    int maxHp = 100;
    int currentHp;
    //Sliderを入れる
    public Slider slider;
    public GameObject Boss;

    // public static BossHPBar instance;
    // public void Awake(){
    //     if(instance == null){
    //         instance = this;
    //     }
    // }

    void Start()
    {
        scoreObject = GameObject.Find("GameObject");
        GameObject boss = GameObject.Find ("Boss");
        Debug.Log ("target1 = " + boss);

        //Sliderを満タンにする。
        slider.value = 1;
        //現在のHPを最大HPと同じに。
        currentHp = maxHp;
        Debug.Log("Start currentHp : " + currentHp);
    }

    //ColliderオブジェクトのIsTriggerにチェック入れること。
    void OnTriggerEnter2D(Collider2D col)
    {
        //Bulletタグのオブジェクトに触れると発動
        if (col.tag == "Bullet")
        {
            //ダメージは1～100の中でランダムに決める。
            int damage = 1;
            Debug.Log("damage : " + damage);

            //現在のHPからダメージを引く
            currentHp = currentHp - damage;
            Debug.Log("After currentHp : " + currentHp);

            //最大HPにおける現在のHPをSliderに反映。
            //int同士の割り算は小数点以下は0になるので、
            //(float)をつけてfloatの変数として振舞わせる。
            slider.value = (float)currentHp / (float)maxHp; ;
            Debug.Log("slider.value : " + slider.value);

        if(currentHp <= 0){
            Destroy(this.gameObject);
            Destroy(Boss);
            Destroy(slider.gameObject);
            scoreObject.GetComponent<CountText>().AddScore();

            GameObject boss = GameObject.Find ("Boss");
            Debug.Log ("target1 = " + boss);
        }

            Destroy(col.gameObject);//これで消えてる
        }
    }



}