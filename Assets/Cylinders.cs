using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cylinders : MonoBehaviour
{
    public GameObject CylinderGreen;
    public GameObject CylinderRed;
    public GameObject CylinderBlack;

    float currentTime = 0.000f;
    float startingTime = 5.000f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    private void setOff()
    {
        CylinderGreen.SetActive(false);
        CylinderRed.SetActive(false);
        CylinderBlack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (mainScript.instance.Speed == 0)
        {
            CountdownTimer.instance.countdownText.fontStyle = FontStyle.Bold;

            if (pointer.instance.number <= 0)
            {
                CylinderRed.SetActive(false);
                CylinderBlack.SetActive(false);
                CylinderGreen.SetActive(true);
                currentTime -= Time.deltaTime;
            }

            if (pointer.instance.number > 0 && pointer.instance.number <= 7)
            {
                CylinderBlack.SetActive(false);
                CylinderGreen.SetActive(false);
                CylinderRed.SetActive(true);
                currentTime -= Time.deltaTime;

            }

            if (pointer.instance.number >= 8 && pointer.instance.number <= 14)
            {
                CylinderRed.SetActive(false);
                CylinderGreen.SetActive(false);
                CylinderBlack.SetActive(true);
                currentTime -= Time.deltaTime;
            }
        }

        if (currentTime <= 0.000f)
        {
            CountdownTimer.instance.countdownText.fontStyle = FontStyle.Normal;
            setOff();
        }

        if (mainScript.instance.isSpin)
        {
            CountdownTimer.instance.countdownText.fontStyle = FontStyle.Normal;
            setOff();
            currentTime = startingTime;
        }
    }
}
