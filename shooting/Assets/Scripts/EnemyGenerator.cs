using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    public GameObject Enemy;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;//時間関係

            GameObject go = Instantiate(Enemy) as GameObject;
            int py = Random.Range(-4, 4);
            go.transform.position = new Vector3(12, py, 0);
        }
    }
}
