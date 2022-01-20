using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziki : MonoBehaviour
{
    public GameObject tama;
    public GameObject tama2;
    Vector3 pos;
    Transform myTransform;
    // Start is called before the first frame update
    float span = 0.4f;
    float delta = 0;
    private bool isShoot = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("s"))
        {
            transform.Translate(0, -0.05f, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0.05f, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(0.05f, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-0.05f, 0, 0);
        }
        transform.localPosition = Utils.ClampPosition(transform.localPosition);

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            myTransform = this.transform;
            pos = myTransform.position;
            pos.y -= 0.27f;
            Instantiate(tama, pos, Quaternion.identity);
        }
        if (Input.GetKeyDown("space") && isShoot)
        {
            Instantiate(tama2, transform.position, Quaternion.identity);
            StartCoroutine("ReturnBullet");
        }
    }

    IEnumerator ReturnBullet()
    {  
        isShoot = false;
        yield return new WaitForSeconds(5.0f); 
        isShoot = true;
    }
}
