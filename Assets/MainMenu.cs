using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    [SerializeField] private string loadLevel;

    public void HiScore()
    {
        SceneManager.LoadScene(loadLevel);
    }

    [SerializeField] private string loadLevel2;

    public void Credits()
    {
        SceneManager.LoadScene(loadLevel2);
    }
}
