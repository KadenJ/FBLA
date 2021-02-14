using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soreinsurance : MonoBehaviour
{

    public int score;
    public void scoreInsurance()
    {
        score = 9999;

        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
        Debug.Log("ScoreInsure");
    }
}
