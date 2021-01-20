using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIndicators : MonoBehaviour
{
    public float rotationPoint;
    public float rotationSpeed;
   
    void Start()
    {
        rotationPoint = transform.localRotation.z;
       
    }
    private void Update()
    {
        rotationPoint += rotationSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(90, 0, rotationPoint);
        if (rotationPoint > 360)
        {
            rotationPoint = 0;
        }
    }
}
