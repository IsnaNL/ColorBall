using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatforms : MonoBehaviour
{
    public Transform platform;
    public Transform platform2;
    public float rotationsPointPlatform;
    public float rotationsPointPlatform2;
    public float rotationSpeed;
    void Start()
    {
        rotationsPointPlatform = platform.localRotation.z;
        rotationsPointPlatform2 = platform2.localRotation.z;
    }

    void Update()
    {
        rotationsPointPlatform += rotationSpeed * Time.deltaTime;
        rotationsPointPlatform2 += rotationSpeed * Time.deltaTime;
        if (rotationsPointPlatform > 360)
        {
            rotationsPointPlatform = 0;
        }
        if (rotationsPointPlatform2 > 360)
        {
            rotationsPointPlatform2 = 0;
        }

        platform.localRotation = Quaternion.Euler(0, 0, rotationsPointPlatform);
        platform2.localRotation = Quaternion.Euler(0, 0, rotationsPointPlatform2 + 90);
    }
}
