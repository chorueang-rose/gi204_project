using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Transform cameraTransform;

    void Update()
    {
        float x = 0;
        float z = 0;

        if (Input.GetKey(KeyCode.W)) z = 1;
        if (Input.GetKey(KeyCode.S)) z = -1;
        if (Input.GetKey(KeyCode.A)) x = -1;
        if (Input.GetKey(KeyCode.D)) x = 1;

        Vector3 move = cameraTransform.forward * z + cameraTransform.right * x;
        move.y = 0;

        transform.position += move.normalized * speed * Time.deltaTime;

        if (move != Vector3.zero)
        {
            transform.forward = move;
        }
    }
}