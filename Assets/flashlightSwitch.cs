using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightSwitch : MonoBehaviour
{

    public Light flashlight;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }
    }
}
