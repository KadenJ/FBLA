using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeTips : MonoBehaviour
{
    public BoxCollider collider;
    public GameObject tip1;
    public GameObject tip2;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("tip2");
        tip1.SetActive(false);
        
        StartCoroutine(tipChange());
        
        
    }
    IEnumerator tipChange()
    {
        
        yield return new WaitForSeconds(2);

        Destroy(collider);
        tip2.SetActive(true);

        yield return new WaitForSeconds(17);

        tip2.SetActive(false);
        
    }
}

