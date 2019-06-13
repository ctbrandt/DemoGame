using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Reference to Rigidbody component called "rb"
    public Rigidbody rb;
    
    public float forwardForce = 2000f;
    public float sidewaysForce = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // We marked this as "fixed" update because
    // we are using it to alter physics
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        /*
        if ( Input.GetKey("w")) {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }

        if ( Input.GetKey("s")) {
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        }
         */
    }
}
