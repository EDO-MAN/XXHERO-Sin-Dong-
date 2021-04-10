using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameCountdown : MonoBehaviour
{
    private int timer = 0;
    public GameObject countdown1;
    public GameObject countdown2;
    public GameObject countdown3;

    void Start()
    {
        timer = 0;
        countdown1.SetActive(false);
        countdown2.SetActive(false);
        countdown3.SetActive(false);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 180)
        {
            timer++;
            if (timer > 0)
            {
                countdown1.SetActive(true);
            }
            if (timer > 60)
            {
                countdown1.SetActive(false);
                countdown2.SetActive(true);
            }
            if (timer > 120)
            {
                countdown2.SetActive(false);
                countdown3.SetActive(true);
            }
            if (timer >= 180)
            {
                countdown3.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }
    }
}
