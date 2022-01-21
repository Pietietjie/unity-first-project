using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour 
{
    public ObstacleMovement obstacleMovement;
    public PlayerMovement playerMovement;

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Obstacle") {
            playerMovement.enabled = false;
            // obstacleMovement.enabled = false;
        }
    }
}
