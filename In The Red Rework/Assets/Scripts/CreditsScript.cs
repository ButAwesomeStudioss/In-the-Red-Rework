using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    public void OnLexButton()
    {
        SceneManager.LoadScene(8);
    }
    public void OnZirenButton()
    {
        SceneManager.LoadScene(6);
    }
    public void OnBennettButton()
    {
        SceneManager.LoadScene(5);
    }
    public void OnLeonButton()
    {
        SceneManager.LoadScene(7);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
