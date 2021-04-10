using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    [SerializeField]
    GameObject Stamina_Slider;
   
    void Start()
    {
        this.Stamina_Slider = GameObject.Find("Stamina_Slider");
    }

    private void Update()
    {
      this.Stamina_Slider.GetComponent<Slider>().value -= 0.5f * Time.deltaTime;
        
    }
    public void AddStamina()
    {
        this.Stamina_Slider.GetComponent<Slider>().value += 1.3f;
    }    
    
}
