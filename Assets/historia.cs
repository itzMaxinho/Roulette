using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class historia : MonoBehaviour
{
    int i = 1;
    int lol;
    int number;
    int numint;
    string numstring;
    string num;
    string tabNumber;
    bool once = false;

    public Text his1;
    public Text his2;
    public Text his3;
    public Text his4;
    public Text his5;
    public Text his6;
    public Text his7;
    public Text his8;

    ArrayList tab = new ArrayList(16);

    // Start is called before the first frame update
    void Start()
    {

    }
    void Tab()
    {
        if (mainScript.instance.Speed < 500 && mainScript.instance.Speed > 30)
        {
            once = true;
        }

        if (mainScript.instance.Speed == 0)
        {
            if (once)
                {
                if (i == 1)
                    {
                    colorCheck();
                    his1.text = pointer.instance.number + ""; 
                    }

                    if (i == 2)
                    {
                    colorChange();
                    his2.text = his1.text;
                    //his2.color = his1.color;
                    his1.text = pointer.instance.number + "";
                    colorCheck();
                    }

                    if (i == 3)
                    {
                    colorChange();
                    his3.text = his2.text;
                    //his3.color = his2.color;
                    his2.text = his1.text;
                    //his2.color = his1.color;
                    his1.text = pointer.instance.number + "";
                    colorCheck();
                    }

                    if (i == 4)
                    {
                    colorChange();
                    his4.text = his3.text;
                    his3.text = his2.text;
                    his2.text = his1.text;
                    his1.text = pointer.instance.number + "";
                    colorCheck();
                    }
                    
                    if (i == 5)
                    {
                    colorChange();
                    his5.text = his4.text;
                    his4.text = his3.text;
                    his3.text = his2.text;
                    his2.text = his1.text;
                    his1.text = pointer.instance.number + "";
                    colorCheck();
                    }

                    if (i == 6)
                    {
                    colorChange();
                    his6.text = his5.text;
                    his5.text = his4.text;
                    his4.text = his3.text;
                    his3.text = his2.text;
                    his2.text = his1.text;
                    his1.text = pointer.instance.number + "";
                    colorCheck();
                    }

                    if (i == 7)
                    {
                    colorChange();
                    his7.text = his6.text;
                    his6.text = his5.text;
                    his5.text = his4.text;
                    his4.text = his3.text;
                    his3.text = his2.text;
                    his2.text = his1.text;
                    his1.text = pointer.instance.number + "";
                    colorCheck();
                    }

                    if (i >= 8)
                    {
                    colorChange();
                    his8.text = his7.text;
                    his7.text = his6.text;
                    his6.text = his5.text;
                    his5.text = his4.text;
                    his4.text = his3.text;
                    his3.text = his2.text;
                    his2.text = his1.text;
                    his1.text = pointer.instance.number + "";
                    colorCheck();
                    }

                i++;
                once = false;
            }
        }
    }

    void colorCheck()
    {
        if (pointer.instance.number == 0)
        {
            his1.color = Color.green;
        }

        if (pointer.instance.number > 0 && pointer.instance.number <= 7)
        {
            his1.color = Color.red;
        }

        if (pointer.instance.number >= 8)
        {
            his1.color = Color.grey;
        }
    }

    void colorChange()
    {
        his8.color = his7.color;
        his7.color = his6.color;
        his6.color = his5.color;
        his5.color = his4.color;
        his4.color = his3.color;
        his3.color = his2.color;
        his2.color = his1.color;
    }

    // Update is called once per frame
    void Update()
    {
        Tab();
        
    }
}
