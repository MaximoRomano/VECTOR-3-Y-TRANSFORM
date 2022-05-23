using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Vector3 movementspeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += movementspeed;
        //transform.eulerAngles += movementspeed;
        if (transform.position.x < 10)
        {
            transform.position += movementspeed;
        }
    }
}   
