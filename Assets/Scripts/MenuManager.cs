using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text highScoreText;

    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
    }
    public void StartButton()
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
