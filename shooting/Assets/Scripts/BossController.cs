using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public GameObject bosstama;
    public GameObject bosstama2;
    Vector3 pos;
    Transform myTransform;
    float span = 0.8f;
    float delta = 0; 
    int Atype;
    int Aposition;
    int deltaTF = 0;
    //float Wtime;
    

    // Update is called once per frame
    void Update()
    {
        if(deltaTF == 0){
            this.delta += Time.deltaTime;
        }
        if (this.delta > this.span)
        {
            Atype = Random.Range(0,2);
            deltaTF =1;
            this.delta = 0;
            if(Atype == 0){
                StartCoroutine("Bullet1");
            }
            if(Atype == 1){
                StartCoroutine("Bullet2");
            }
             
        }
    }
    IEnumerator Bullet1()
    {
        for(int i=0; i<=2; i++){
            myTransform = this.transform;
            pos = myTransform.position;
            pos.x -= 1.0f;
            Aposition = Random.Range(0,2);
            if(Aposition ==0)   
                pos.y += 2f;
            if(Aposition == 1)
                pos.y -= 2f;
            Instantiate(bosstama, pos, Quaternion.identity);
            yield return new WaitForSeconds(0.2f); 
        }
        yield return new WaitForSeconds(Random.Range(0f,1f)); 
        deltaTF = 0;
    }
    IEnumerator Bullet2()
    {
        Aposition = Random.Range(0,3);
        for(int i=0; i<=5; i++){
            myTransform = this.transform;
            pos = myTransform.position;
            pos.x -= 1.0f;
            if(Aposition ==1)   
                pos.y += 2f;
            if(Aposition == 2)
                pos.y -= 2f;
            else{
            }
            Instantiate(bosstama2, pos, Quaternion.identity);
            yield return new WaitForSeconds(0.2f); 
        }
        yield return new WaitForSeconds(Random.Range(0f,2f)); 
        deltaTF = 0;
    }
}
