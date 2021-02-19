using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public static bool inputNameUI = true;
    public GameObject namePrompt;
    
    public string theName;
    public GameObject inputField;

    private void Start()
    {
        Cursor.visible = true;
    }
    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        
        PlayerPrefs.SetString("name", theName);
        PlayerPrefs.Save();
        Debug.Log("saved name");
        namePrompt.SetActive(false);
        inputNameUI = false;
        
                
    }
}
