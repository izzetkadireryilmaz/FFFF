using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeppelinManager : MonoBehaviour
{
    public GameObject DeadS;
    public GameObject DeadB;
    void Start()
    {
        DeadS.SetActive(false);
        DeadB.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {   
            DeadB.SetActive(true);
            DeadS.SetActive(true);
            Time.timeScale = 0f;
        }
    }


}
