using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useMap : MonoBehaviour
{
    private bool mapOut = false;
    public GameObject mapUI;

    void Update() {
    if(Input.GetKeyDown(KeyCode.M) && mapOut == false)
        {
            mapOut = true;
            mapUI.SetActive(true);
        }else if(Input.GetKeyDown(KeyCode.M) && mapOut == true)
        {
            mapOut = false;
            mapUI.SetActive(false);
        }
       
        }

}
