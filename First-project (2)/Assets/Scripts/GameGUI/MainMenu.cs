using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void OnCkickNewGame()
    {
        SceneManager.LoadScene("StageSelectScene");
        Debug.Log("게임시작");
    }
    public void OnCkickOption()
    {
        Debug.Log("옵션");
    }

    
    public void OnCkickExit()
    {
        Debug.Log("게임종료");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }


}
