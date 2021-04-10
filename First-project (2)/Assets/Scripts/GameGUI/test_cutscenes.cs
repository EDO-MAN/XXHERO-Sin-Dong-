using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class test_cutscenes : MonoBehaviour
{ 
    public Image webtoon;
    [SerializeField]
    public Sprite[] webtoon_spt;
   
    private int count;
    void Start()
    {
        webtoon = GetComponent<Image>();
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            webtoon.sprite = webtoon_spt[count];
            count++;
            Debug.Log("스페이스바");
            if (webtoon_spt.Length == count)
            {
                SceneManager.LoadScene("NewPlaying");
            }
        }
    }  
}
