using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spirit : MonoBehaviour
{
    public int curSpirt = 0;
    public int maxSpirt = 100;

    [SerializeField]
    private SpiritMeter spiritMeter;

    [SerializeField]
    private float _inputDelayTime;
    private float _isInputOnDelay;

    // Start is called before the first frame update
    void Start()
    {
        curSpirt = maxSpirt;
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetButtonDown("Scream!") && curSpirt > 0 && _inputDelayTime < Time.time)
        {
            _inputDelayTime = Time.time + _isInputOnDelay; 
            usingSpirit(5);
            Debug.Log("Is repecting"); 
        }
    }

    public void usingSpirit(int sp)
    {
        _isInputOnDelay = Time.time + _inputDelayTime; 

        curSpirt -= sp;
        spiritMeter.SetSpirit(curSpirt);
    }
}
