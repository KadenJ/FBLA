using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadAdditive : MonoBehaviour
{
    public void LoadAddOnClick(int level)
    {
        Application.LoadLevelAdditive(level);
    }
}
