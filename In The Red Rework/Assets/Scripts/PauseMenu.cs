using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{ 
    [SerializeField] GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.gameObject.SetActive(true);
            Debug.Log("Paused Game");
        }
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void Resume()
    {
        pauseMenu.gameObject.SetActive(false);
    }

}
