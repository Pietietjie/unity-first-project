using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    public float dodgeSpeed = 500f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    // FixedUpdate is like update but works better with phisics
    void FixedUpdate()
    {
        if (Input.GetKey("d")) {
            playerRigidBody.AddForce(dodgeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) {
            playerRigidBody.AddForce(-dodgeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
    }
}
