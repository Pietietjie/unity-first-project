using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody obstacleRigidBody;

    public float obstacleSpeed;

    void FixedUpdate()
    {
        obstacleRigidBody.AddForce(0, 0, -obstacleSpeed * Time.deltaTime);        
    }

}
