using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // makes the mouse disapear when the game starts so you don't click off the screen
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //gets the input of the mouse when it is moved and multiplies it by the sensetivity. Time.deltaTime added for smoothness
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //used to make sure the mouse doesn't get inverted 
        xRotation -= mouseY;
        //makes sure the character can't flip the camera
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //adds the rotation of the character the camera is on
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        
        
        
        
    }

    
    
    
}
