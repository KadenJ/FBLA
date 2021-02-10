﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeLock : MonoBehaviour
{

    public GameObject door;
    public GameObject player;

    int codeLength;
    int placeInCode;

    public string code = "";
    public string attemptedCode;

    public Transform toOpen;

    private void Start()
    {
        codeLength = code.Length;
    }
    // Start is called before the first frame update
    void CheckCode()
    {
        if(attemptedCode == code)
        {
            Open();
            
        }
        else
        {
            Debug.Log("Worng code");
            Close();

        }
    }

    void Open()
    {
        GetComponent<AudioSource>().Play();
        door.GetComponent<Animator>().Play("Door");
    }

    // Update is called once per frame
    public void SetValue(string value)
    {
        placeInCode++;


        if(placeInCode <= codeLength)
        {
            attemptedCode += value;
        }

        if(placeInCode == codeLength)
        {
            CheckCode();

            attemptedCode = "";
            placeInCode = 0;
        }
    }

    public void Close()
    {
        player.GetComponent<AudioSource>().Play();
    }
}
