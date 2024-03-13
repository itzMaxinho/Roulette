using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainScript : MonoBehaviour
{

    public static mainScript instance;

    bool breakIt;
    public bool testy;
    public bool isResetCalled = false;
    public bool isStopCalled;
    public bool isSpin = true;

    float randomNumber = 0;
    public float Speed;
    public float maxSpeed = 600;

    public GameObject pointer;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Speed = maxSpeed;
    }

    private void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        transform.Rotate(0, 0, Speed * Time.deltaTime);

        if (!isSpin && Speed > 0)
        {
            PreStop();
        }
    }

    IEnumerator Delay()
    {
        randomNumber = Random.Range(0.000f, 3.000f);
        Debug.Log("Randomowy czas losowania: " + randomNumber);
        yield return new WaitForSeconds(randomNumber);
        if (breakIt)
        {
            PreStop();
        }
    }

    public void PreStop()
    {
        isStopCalled = true;
        isSpin = false;
        Speed--;
        if (Speed <= 0)
        {
            pointer.GetComponent<BoxCollider>().enabled = true;
            Speed = 0;
        }
    }

    public void Stop()
    {
        breakIt = true;
        StartCoroutine(Delay());
    }

    public void Reset()
    {
        breakIt = false;
            isResetCalled = true;
            isSpin = true;
            pointer.GetComponent<BoxCollider>().enabled = false;
            Speed = maxSpeed;
    }
}
