using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampVelocity : MonoBehaviour
{
    private Rigidbody rb;
    public float sphereMaxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, sphereMaxSpeed);   
    }
}
