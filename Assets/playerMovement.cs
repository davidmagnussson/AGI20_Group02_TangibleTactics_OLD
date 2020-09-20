using UnityEngine;

public class playerMovement : MonoBehaviour
{

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float force = 100f;

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {

        if (Input.GetKey("w"))  // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))  // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))  // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))  // If the player is pressing the "a" key
        {
            // Add a force to the left
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space"))  // If the player is pressing the "a" key
        {
            // Add a force upwards
            if (transform.position.y < 0.2)
            {

                rb.AddForce(0, 2, 0, ForceMode.VelocityChange);
            }
        }
    }
}
