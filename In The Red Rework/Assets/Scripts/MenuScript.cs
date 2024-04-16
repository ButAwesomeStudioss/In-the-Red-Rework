using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //Loads Game Scene
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }
    //Loads Options Menu
    public void OnOptionsButton()
    {
        SceneManager.LoadScene(2);
    }
    //Closes Game
    public void OnQuitButton()
    {
        Application.Quit();
    }
}
