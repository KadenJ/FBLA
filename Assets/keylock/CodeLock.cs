using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeLock : MonoBehaviour
{

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
            StartCoroutine(Open());
        }
        else
        {
            Debug.Log("Worng code");
        }
    }

    IEnumerator Open()
    {
        //changes door rotation
        toOpen.Rotate(new Vector3(0, 90, 0), Space.World);

        yield return new WaitForSeconds(4);

        //toOpen.Rotate(new Vector3(0, -90, 0), Space.World);
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
}
