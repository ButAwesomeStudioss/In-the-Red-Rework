using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OnSettingsButton ()
    {
        SceneManager.LoadScene(2);
    }
<<<<<<< Updated upstream
    public void OnQuitButton ()
=======
    //Goes To Main Menu
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    //Closes Game
    public void OnQuitButton()
>>>>>>> Stashed changes
    {
        Application.Quit();
    }
}
