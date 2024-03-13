using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{

    public float currentTime = 0.000f;
    float startingTime = 35.000f;

    [SerializeField] public Text countdownText;

    public static CountdownTimer instance;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (mainScript.instance.isStopCalled)
        {
            countdownText.color = Color.white;
            countdownText.text = "LOSOWANIE";
            mainScript.instance.isStopCalled = false;
            return;
        }

        if (mainScript.instance.isResetCalled)
        {
            currentTime = startingTime;
            countdownText.color = Color.white;
            countdownText.text = "LOSOWANIE";
            mainScript.instance.isResetCalled = false;
        }

        if (mainScript.instance.Speed == 0)
        {
            currentTime -= Time.deltaTime;
            countdownText.text = currentTime.ToString("f3");

            if (currentTime >= 30.000f)
            {
                countdownText.text = pointer.instance.number + "";
            }

            if (currentTime <= 15.000f)
            {
                countdownText.color = Color.yellow;
            }

            if (currentTime <= 5.000f)
            {
                countdownText.color = Color.red;
            }

            if (currentTime <= 0)
            {
                mainScript.instance.Reset();
            }
        }
    }
}
