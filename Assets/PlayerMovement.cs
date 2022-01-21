using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float dodgeSpeed = 500f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    // FixedUpdate is like update but works better with phisics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 500 * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(dodgeSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a")) {
            rb.AddForce(-dodgeSpeed * Time.deltaTime, 0, 0);

        }
    }
}
