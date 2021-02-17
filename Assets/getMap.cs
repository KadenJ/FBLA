using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getMap : MonoBehaviour
{
    public BoxCollider collectMap;
    public GameObject mapUI;

    private void OnTriggerEnter(Collider other)
    {
        mapUI.SetActive(true);
    }
}
