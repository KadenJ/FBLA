using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchUI : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject backgroundText;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuUI.SetActive(false);
        backgroundText.SetActive(false);
    }

    public void SwitchUI()
    {
        mainMenuUI.SetActive(true);
        backgroundText.SetActive(true);
    }


}
