using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitch : MonoBehaviour
{
    public GameObject Reset;
    public GameObject Stop;

    public void Switch()
    {
       if (CountdownTimer.instance.currentTime <= 0)
        {
            Reset.SetActive(false);
            Stop.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Switch();
    }
}
