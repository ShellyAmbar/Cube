using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour {
    public PlayerMovement playerMovement;
    // Use this for initialization
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstcle") {
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndOfGame();
        }

        
    }
}

