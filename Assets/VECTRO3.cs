using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VECTRO3 : MonoBehaviour
{
    public Vector3 mivector;
    public GameObject objeto;
    void Start()
    {
        objeto.transform.position = mivector;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
