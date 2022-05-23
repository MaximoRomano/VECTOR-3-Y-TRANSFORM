using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptplataforma : MonoBehaviour
{
    public Vector3 mivector;
    public float limiiteder;
    public float limiteizq;
    public float movmentspeed;
    public bool toright;
    public GameObject  prefab1;
    public GameObject prefab2;

    void Start()
    {
        toright = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toright == true ) {
            transform.position += new Vector3(movmentspeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(movmentspeed, 0, 0);
        }
        if(transform.position.x > limiiteder)
        {
            toright = false;

        }
         else if(transform.position.x < limiteizq)
        {
            toright = true;
        }
       


    }
}
