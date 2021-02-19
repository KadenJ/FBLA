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

    private void Start()
    {
        Time.timeScale = 1f;
    }

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

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0.0001f;
        GameIsPaused = true;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
                               
    }

    [SerializeField] private string loadLevel;
        public void LoadMenu()
    {
        Debug.Log("Loading menu");
        SceneManager.LoadScene(loadLevel);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(currentScene);
        

    }

    public void QuitGame()
    {
        Debug.Log("quitting");
            Application.Quit();
    }
}
