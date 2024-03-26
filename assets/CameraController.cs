using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 5f;
    public float minAngle = -60f; // Minimum vertical angle
    public float maxAngle = 60f;  // Maximum vertical angle

    private bool isDragging = false;
    private float verticalRotation = 0f; // Track vertical rotation separately

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        Vector3 movement = transform.right * horizontal + transform.forward * vertical;
        movement.y = 0; // Prevents the camera from moving up/down

        transform.Translate(movement, Space.World);

        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
        if (isDragging)
        {
            float mouseX = Input.GetAxis("Mouse X") * rotateSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * rotateSpeed;

            transform.Rotate(Vector3.up, mouseX, Space.World);

            // Adjust vertical rotation based on mouseY, clamped within the specified angles
            verticalRotation -= mouseY;
            verticalRotation = Mathf.Clamp(verticalRotation, minAngle, maxAngle);

            // Apply the vertical rotation around the X-axis
            transform.localEulerAngles = new Vector3(verticalRotation, transform.localEulerAngles.y, 0);
        }
    }
}
