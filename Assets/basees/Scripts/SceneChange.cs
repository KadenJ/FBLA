﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
        
    [SerializeField] private string loadLevel;
        
    void OnTriggerEnter(Collider other)
    {
                

        if (other.CompareTag("Player"))
        {

            
            SceneManager.LoadSceneAsync(loadLevel);
             
        }
           

    }

    
}
