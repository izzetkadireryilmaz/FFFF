using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Karakter Kontrolü için
    int score;
    public GameObject shieldZeppelin;
    private float leftPosition = -1f;
    private float centerPosition = 0f;
    private float rightPosition = 1f;
    public Text Score;
    // ekranýn ortasýný belirliyoruz.
    private float screenCenterX;

    void Start()
    {
        // Karakter Kontrolü için
        shieldZeppelin.SetActive(false);
        score = 0;
        // ekraný ne tarafýna týklandýðýný algýlayabilmek için ekraný ortadan bölüyoruz.
        screenCenterX = Screen.width / 2;
    }

    void Update()
    {
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
        }
        

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            if (mousePosition.x > screenCenterX)
            {
                MoveRight();
            }
            else if (mousePosition.x < screenCenterX)
            {
                MoveLeft();
            }
        }
    }

    void MoveRight()
    {
        float playerX = transform.position.x;
        if (playerX == leftPosition)
        {
            transform.position = new Vector3(centerPosition, transform.position.y, transform.position.z);
        }
        else if (playerX == centerPosition)
        {
            transform.position = new Vector3(rightPosition, transform.position.y, transform.position.z);
        }
    }

    void MoveLeft()
    {
        float playerX = transform.position.x;
        if (playerX == rightPosition)
        {
            transform.position = new Vector3(centerPosition, transform.position.y, transform.position.z);
        }
        else if (playerX == centerPosition)
        {
            transform.position = new Vector3(leftPosition, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            score++;
            Score.text = score.ToString();
        }
        if (other.tag == "Shield")
        {
            shieldZeppelin.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
