using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //calls the character controller on the player
    public CharacterController controller;

    //how fast the character would go as a float(decimal number)
    public float speed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Gets the input from the player and saves it as x or z (left or right for x; forward or back for z)
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //uses a vector 3 to store the inputs of the player as a float by getting its position and multiplying it by x or z (Horizontal and Vertical has a default value of .001)
        Vector3 move = transform.right * x + transform.forward * z;

        //takes the character controller of the player and changes its position by multiplying the inputs stored by speed. Time.deltaTime is added to make it smooth
        controller.Move(move * speed * Time.deltaTime);

    }
}
