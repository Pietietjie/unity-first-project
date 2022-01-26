using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour 
{
    public ObstacleMovement obstacleMovement;
    public PlayerMovement playerMovement;

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Obstacle") {
            FindObjectOfType<GameStateManager>().EndRun();
        }
    }
}
