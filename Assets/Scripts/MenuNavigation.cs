using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Explanation");
    }

    public void Play2()
    {
        SceneManager.LoadScene("Explanation2");
    }

    public void ToGame()
    {
        SceneManager.LoadScene("Main Game");
    }

    public void Quit()
    {
        Application.Quit();
    }
}