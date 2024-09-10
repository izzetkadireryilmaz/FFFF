using System.Collections;
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
    public void TryAgainButton()
    {
        StartCoroutine(ReklamDelay());
    }
    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitButton()
    {
        Application.Quit();
    }

    IEnumerator ReklamDelay()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(1);
    }
}
