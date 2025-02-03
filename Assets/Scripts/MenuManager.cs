using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
    public void TryAgainButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitButton()
    {
        Application.Quit();
    } 
}
