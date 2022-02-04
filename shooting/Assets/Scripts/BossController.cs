using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public GameObject bosstama;
    public GameObject bosstama2;
    Vector3 pos;
    Transform myTransform;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {        
            //Instantiate(bosstama2, pos, Quaternion.identity);
            StartCoroutine("Bullet2");
        }
        if (Input.GetKeyDown("t"))
        {   
            myTransform = this.transform;
            pos = myTransform.position;
            pos.x -= 1.0f;   
            pos.y -= 0.27f;
            Instantiate(bosstama, pos, Quaternion.identity);
        }

    }
    IEnumerator Bullet2()
    {
        for(int i=0; i<=5; i++){
            myTransform = this.transform;
            pos = myTransform.position;
            pos.x -= 1.0f;
            pos.y -= 0.27f;
            Instantiate(bosstama2, pos, Quaternion.identity);
            yield return new WaitForSeconds(0.2f); 
        }
    }
}
