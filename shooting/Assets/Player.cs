using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject tama;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("down"))
        {
            transform.Translate(0, -0.05f, 0);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(0, 0.05f, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(0.05f, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-0.05f, 0, 0);
        }
        if (Input.GetKeyDown("space"))
		{
			Instantiate(tama, transform.position, Quaternion.identity);
		}
    }
}