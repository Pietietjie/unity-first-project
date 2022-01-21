using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    // FixedUpdate is like update but works better with phisics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);        
    }
}
