using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideWayForce = 500f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {

            rb.AddForce(sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -4.5f)
        {

           FindObjectOfType<GameManagement>().EndGame();

        }


    }
}
