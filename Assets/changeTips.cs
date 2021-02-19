using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeTips : MonoBehaviour
{
    public BoxCollider changeText;
    public GameObject tip1;
    public GameObject tip2;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("tip2");
        tip1.SetActive(false);
        
        StartCoroutine(tipChange());
        
        
    }
    IEnumerator tipChange()
    {
        
        

        
        tip2.SetActive(true);

        yield return new WaitForSeconds(17);

        tip2.SetActive(false);
        
    }
}

