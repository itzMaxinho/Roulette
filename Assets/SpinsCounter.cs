using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinsCounter : MonoBehaviour
{
    public Text Counter;
    int i;
    int display;
    bool once;
    // Start is called before the first frame update
    void Start()
    {
        i = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (mainScript.instance.Speed != 0)
        {
            once = true;
        }

        if (mainScript.instance.Speed == 0 && once)
        {
            i = i - 1;
            display = i;
            Counter.text = display.ToString();
            once = false;
        }

        if (i <= 25 && i > 10)
        {
            Counter.color = Color.yellow;
        }

        if (i <= 10)
        {
            Counter.color = Color.red;
        }

        if (i <= 0)
        {
            Counter.text = "GG";
        }
    }
}
