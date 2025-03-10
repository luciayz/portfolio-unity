using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public float mouseSensitivity = 2f;  // Sensibilidad del mouse
    public float moveSpeed = 5f;         // Velocidad de movimiento
    private float xRotation = 0f;        // Control de la rotación vertical

    public Transform playerBody;         // Referencia al cuerpo del jugador

    void Update()
    {
        // Rotación del mouse en el eje X (horizontal)
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        // Rotación del mouse en el eje Y (vertical)
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotación vertical: Limitar la rotación de la cámara para evitar que se dé vuelta
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Aplicar la rotación a la cámara (cambiar solo en el eje X)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotación horizontal: Afecta al cuerpo del jugador (sin límites)
        playerBody.Rotate(Vector3.up * mouseX);

        // Movimiento en el plano horizontal (WASD)
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // Movimiento de la cámara: Desplazarse hacia adelante/atrás y hacia los lados
        transform.parent.Translate(moveX, 0f, moveZ);
    }
}

