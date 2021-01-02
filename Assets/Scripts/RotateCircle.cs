using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    public GameObject torus1;
    public GameObject torus2;
    public float rotationsPointTorus1;
    public float rotationsPointTorus2;
    public float rotationSpeed;
    void Start()
    {
        rotationsPointTorus1 = torus1.transform.localRotation.z;
        rotationsPointTorus2 = torus2.transform.localRotation.z;
    }

    void Update()
    {
        rotationsPointTorus1 += rotationSpeed * Time.deltaTime;
        rotationsPointTorus2 += rotationSpeed * Time.deltaTime;
        if(rotationsPointTorus1 > 360)
        {
            rotationsPointTorus1 = 0;
        }
        if (rotationsPointTorus2 > 360)
        {
            rotationsPointTorus2 = 0;
        }
     
        torus1.transform.localRotation = Quaternion.Euler(0, 0, rotationsPointTorus1);
        torus2.transform.localRotation = Quaternion.Euler(0, 0, rotationsPointTorus2 + 180);
    }
}
