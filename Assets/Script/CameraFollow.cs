using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Transform player;
    public float distance = 6f;
    public float height = 3f;
    public float rotationSpeed = 120f;

    float angle = 0;

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            angle -= rotationSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            angle += rotationSpeed * Time.deltaTime;
        }

        Quaternion rotation = Quaternion.Euler(0, angle, 0);
        Vector3 offset = rotation * new Vector3(0, height, -distance);

        transform.position = player.position + offset;
        transform.LookAt(player);
    }
}