using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public float mouseSensitivity = 2f;  
    public float moveSpeed = 5f;        
    private float xRotation = 0f;        

    public Transform playerBody;         

    void Update()
    {
       
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

      
        playerBody.Rotate(Vector3.up * mouseX);

    
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

       
        transform.parent.Translate(moveX, 0f, moveZ);
    }
}

