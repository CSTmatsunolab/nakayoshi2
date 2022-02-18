using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public GameObject bosstama;
    public GameObject bosstama2;
    Vector3 pos1;
    Vector3 pos2;
    Transform myTransform;
    float span1 = 0.8f;
    float span2 = 1.0f;
    float delta1 = 0; 
    float delta2 = 0;
    int Atype;
    int Aposition1;
    int Aposition2;
    int deltaTF1 = 0;
    int deltaTF2 = 0;
    //float Wtime;
    

    // Update is called once per frame
    void Update()
    {
        if(deltaTF1 == 0){
            this.delta1 += Time.deltaTime;
        }
        if(deltaTF2 == 0){
            this.delta2 += Time.deltaTime;
        }

        if (this.delta1 > this.span1)
        {
            deltaTF1 =1;
            this.delta1 = 0;
            StartCoroutine("Bullet1");
        }
        if (this.delta2 > this.span2)
        {
            deltaTF2 =1;
            this.delta2 = 0;
            StartCoroutine("Bullet2");
        }
    }
    IEnumerator Bullet1()
    {
        for(int i=0; i<=2; i++){
            myTransform = this.transform;
            pos1 = myTransform.position;
            pos1.x -= 1.0f;
            Aposition1 = Random.Range(0,2);
            if(Aposition1 ==0)   
                pos1.y += 2f;
            if(Aposition1 == 1)
                pos1.y -= 2f;
            Instantiate(bosstama, pos1, Quaternion.identity);
            yield return new WaitForSeconds(0.2f); 
        }
        yield return new WaitForSeconds(Random.Range(0f,1f)); 
        span1 = Random.Range(0.0f,2.0f) + 0.5f;
        deltaTF1 = 0;
    }
    IEnumerator Bullet2()
    {
        Aposition2 = Random.Range(0,3);
        for(int i=0; i<=5; i++){
            myTransform = this.transform;
            pos2 = myTransform.position;
            pos2.x -= 1.0f;
            if(Aposition2 ==1)   
                pos2.y += 2f;
            if(Aposition2 == 2)
                pos2.y -= 2f;
            else{
            }
            Instantiate(bosstama2, pos2, Quaternion.identity);
            yield return new WaitForSeconds(0.2f); 
        }
        yield return new WaitForSeconds(Random.Range(0f,1f)); 
        span2 = Random.Range(1.0f,3.0f);
        deltaTF2 = 0;
    }
}