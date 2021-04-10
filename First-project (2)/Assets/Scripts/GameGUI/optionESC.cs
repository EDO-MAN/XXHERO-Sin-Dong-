using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField]
    GameObject menuSet;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (Time.timeScale>0)
            {
                menuSet.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                menuSet.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }
    }

    public void Continue()
    {
        Debug.Log("계속하기");
        menuSet.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void GameExit()
    {
        Debug.Log("게임종료");
        Application.Quit();
    }
}
