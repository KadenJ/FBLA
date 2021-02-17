using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tipClose : MonoBehaviour
{
    public BoxCollider collider;
    public GameObject tip;


     void Start()
    {
        tip.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        StartCoroutine(closeTip());


    }

    IEnumerator closeTip()
    {
        yield return new WaitForSeconds(2);
        tip.SetActive(false);
    }
}
