using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Karakter Kontrolü için
    int score;
    public GameObject shieldZeppelin;
    public TMP_Text Score;

    void Start()
    {
        shieldZeppelin.SetActive(false);
        score = 0;
    }

    void Update()
    {
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            score++;
            Score.text = score.ToString();
            Destroy(other.gameObject);
        }
        if (other.tag == "Shield")
        {
            shieldZeppelin.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
