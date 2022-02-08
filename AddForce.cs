using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
     public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 200f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }

    public void Addforce()
    {
        rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    
}
