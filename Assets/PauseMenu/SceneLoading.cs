using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoading : MonoBehaviour
{
    //[SerializeField]
    //public Slider _progressBar;
    // Start is called before the first frame update
    
    void Start()
    {
        StartCoroutine(LoadAsyncOperation());
        //start async operation
    }

    [SerializeField] private string loadLevel;
    IEnumerator LoadAsyncOperation()
    {

        AsyncOperation level = SceneManager.LoadSceneAsync(loadLevel);
        while(level.progress < 1)
        {
            //_progressBar.value = level.progress;
            
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
