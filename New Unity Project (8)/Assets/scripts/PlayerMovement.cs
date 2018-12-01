
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float FloatForce;
    public float SideForce;
    
    void FixedUpdate() {
       
        rb.AddForce(0, 0, FloatForce * Time.deltaTime);
        if (Input.GetKey("l"))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("r"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
         if(rb.position.y<50){
            FindObjectOfType<GameManager>().EndOfGame();
            
        }
       
    }
}
