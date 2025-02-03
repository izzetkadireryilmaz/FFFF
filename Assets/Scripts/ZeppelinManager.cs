using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeppelinManager : MonoBehaviour
{
    public Canvas GameCanvas, DeadCanvas;
    void Start()
    {
        CanvasControl(GameCanvas, DeadCanvas);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {   
            CanvasControl(DeadCanvas, GameCanvas);
            Time.timeScale = 0f;
        }
    }

    void CanvasControl(Canvas open, Canvas close)
    {
        open.gameObject.SetActive(true);
        close.gameObject.SetActive(false);
    }
}
