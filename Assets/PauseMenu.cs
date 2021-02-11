using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    SC_CharacterController characterController;

    // Update is called once per frame


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
                               
                              
            }
        }

        
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0.0001f;
        GameIsPaused = true;

        Cursor.lockState = CursorLockMode.None;
                               
    }

    [SerializeField] private string loadLevel;
    public void LoadMenu()
    {
        Debug.Log("Loading menu");
        SceneManager.LoadScene(loadLevel);

    }

    public void QuitGame()
    {
        Debug.Log("quitting");
            Application.Quit();
    }
}
