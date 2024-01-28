using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiritMeter : MonoBehaviour
{
    public Slider spiritMeter;
    public Spirit playerSpirit;
        
    // Start is called before the first frame update
    void Start()
    {

        playerSpirit = GameObject.FindGameObjectWithTag("Player").GetComponent<Spirit>(); 
        spiritMeter = GetComponent<Slider>();
        spiritMeter.maxValue = playerSpirit.maxSpirt;
        spiritMeter.value = playerSpirit.maxSpirt; 
    }

   
    public void SetSpirit(int SP)
    {
        spiritMeter.value = SP; 
    }   
}
