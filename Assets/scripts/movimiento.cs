using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public float mouseSensitivity = 2f;  // Sensibilidad del mouse
    public float moveSpeed = 5f;         // Velocidad de movimiento

    private float xRotation = 0f;

    void Update()
    {
        // Obtener la rotación del mouse en los ejes X y Y
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Rotación de la cámara
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.parent.Rotate(Vector3.up * mouseX);

        // Movimiento con las teclas WASD
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.parent.Translate(moveX, 0, moveZ);
    }
}
