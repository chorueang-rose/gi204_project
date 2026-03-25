using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveForce = 20f;
    public float bounceForce = 8f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0, z);

        rb.AddForce(move * moveForce);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Vector3 normal = collision.contacts[0].normal;
            rb.AddForce(normal * bounceForce, ForceMode.Impulse);
        }
    }
}