using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public Vector3 playerspeed;
    public float movmentspeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3 (movmentspeed, 0, 0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(movmentspeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, movmentspeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, movmentspeed, 0);
        }


    }
}
