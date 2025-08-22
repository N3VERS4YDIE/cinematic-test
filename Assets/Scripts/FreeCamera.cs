using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float shiftMultiplier = 2f;
    public float rotationSpeed = 100f;

    private Vector3 currentVelocity;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        HandleRotation();
        HandleMovement();
    }

    void HandleRotation()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.right, -mouseY * rotationSpeed * Time.deltaTime, Space.Self);
    }

    void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        float moveY = Input.GetAxis("UpDown");

        Vector3 moveDirection = transform.right * moveX + transform.forward * moveZ + transform.up * moveY;
        float speed = moveSpeed * (Input.GetKey(KeyCode.LeftShift) ? shiftMultiplier : 1f);

        currentVelocity = moveDirection * speed * Time.deltaTime;
        transform.position += currentVelocity;
    }
}
