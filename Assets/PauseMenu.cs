using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            //unpause
            isPaused = false;
            Time.timeScale = 1.0f;
            pauseUI.SetActive(false);
        }
        else
        {
            //pause
            isPaused = true;
            Time.timeScale = 0.0f;
            pauseUI.SetActive(true);
        }
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
