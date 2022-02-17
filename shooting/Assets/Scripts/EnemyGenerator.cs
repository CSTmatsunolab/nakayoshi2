using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    //public CountText countText;
    
    void Start()
    {
        scoreObject = GameObject.Find("GameObject"); 
        //    GameObject go = Instantiate(Boss) as GameObject;
        //    go.transform.position = new Vector3(8, 0, 0);
        //     //テスト用
    }
    public GameObject scoreObject;
    public GameObject Enemy;
    public GameObject Boss;
    float span = 1.0f;
    float delta = 0;
    bool flag = false;//ボス有無,boss破壊時に引っ張ってくる必要あり?  

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if ((this.delta > this.span)&&(flag == false))　//関数化
        {
             this.delta = 0;//時間関係

             GameObject go = Instantiate(Enemy) as GameObject;
             int py = Random.Range(-4, 4);
             go.transform.position = new Vector3(12, py, 0);
         }

        int Boss_span = 0;
        //Debug.Log(Boss_span);
        Boss_span = scoreObject.GetComponent<CountText>().Score;
        //Debug.Log(Boss_span);

        // Debug.Log(flag_g);
        // Debug.Log(enemyController.flag);
        // flag_g = enemyController.flag;//BossObject.GetComponent<BossController>().flag;//Con→Genにflag引っ張り跡地

         if ((Boss_span % 3 == 1) && (flag == false) )//Boss出現 条件どうする
         // 別変数用意　
         {
            Boss_span = 0;//時間関係

           GameObject go = Instantiate(Boss) as GameObject;
             go.transform.position = new Vector3(8, 0, 0);
              flag = true;
         }

        GameObject boss = GameObject.Find ("Boss(Clone)");
         if(GameObject.Find ("Boss(Clone)") ){
            Debug.Log("true");
            flag = true;
         }else{
            Debug.Log("false");
            flag = false;
         }

    }
}
