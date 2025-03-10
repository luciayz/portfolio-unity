using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public float mouseSensitivity = 2f;  // Sensibilidad del mouse
    public float moveSpeed = 5f;         // Velocidad de movimiento
    private float xRotation = 0f;        // Control de la rotaci�n vertical

    public Transform playerBody;         // Referencia al cuerpo del jugador

    void Update()
    {
        // Rotaci�n del mouse en el eje X (horizontal)
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        // Rotaci�n del mouse en el eje Y (vertical)
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotaci�n vertical: Limitar la rotaci�n de la c�mara para evitar que se d� vuelta
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Aplicar la rotaci�n a la c�mara (cambiar solo en el eje X)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotaci�n horizontal: Afecta al cuerpo del jugador (sin l�mites)
        playerBody.Rotate(Vector3.up * mouseX);

        // Movimiento en el plano horizontal (WASD)
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // Movimiento de la c�mara: Desplazarse hacia adelante/atr�s y hacia los lados
        transform.parent.Translate(moveX, 0f, moveZ);
    }
}

