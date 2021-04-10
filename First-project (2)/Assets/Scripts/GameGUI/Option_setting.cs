using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option_setting : MonoBehaviour
{
    [SerializeField]
    GameObject Option_menu;

    public Dropdown resolition_option;
    public Toggle fullscreen;
    List<Resolution> resolutions = new List<Resolution>();
    FullScreenMode screenMode;
    int number_resolution;
    public void OnCkickOption()
    {
        Option_menu.SetActive(true);
        Debug.Log("옵션");
    }
    public void initUI()
    {
        for (int i = 0; i < Screen.resolutions.Length; i++)
        {
            if (Screen.resolutions[i].refreshRate == 144|| Screen.resolutions[i].refreshRate == 60)
                resolutions.Add(Screen.resolutions[i]);
        }
        resolition_option.options.Clear();

        int num = 0;
        foreach (Resolution item in resolutions)
        {
            Dropdown.OptionData option = new Dropdown.OptionData();
            option.text = item.width + " x " + item.height + " " + item.refreshRate + " hz";
            resolition_option.options.Add(option);

            if (item.width == Screen.width && item.height == Screen.height)
                resolition_option.value = num;   
            num++;
        }
        resolition_option.RefreshShownValue();
        fullscreen.isOn = Screen.fullScreenMode.Equals(FullScreenMode.FullScreenWindow) ? true : false;
    }
    void Start()
    {
        initUI();
    }
    public void resolutionChange(int x)
    {
        number_resolution = x;
    }
    public void Fullscreen(bool isFull)
    {
        screenMode = isFull ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed;
    }
    public void Check()
    {
        Screen.SetResolution(resolutions[number_resolution].width,
            resolutions[number_resolution].height, screenMode);
        
        Debug.Log("나가기");
        
       //Option_menu.SetActive(false);
    }
}
