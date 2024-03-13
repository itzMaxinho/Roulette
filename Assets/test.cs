using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public static test instance;

    private void Awake()
    {
        instance = this;
    }

    float randomTime = 11.000f;
    float randomNumber;
    public Text tekst;
    bool jest;

    // Start is called before the first frame update
    void Start()
    {
    }
    public void ran()
    {
        randomNumber = Random.Range(10.000f, 30.000f);
        randomTime = randomNumber;
    }

    // Update is called once per frame
    void Update()
    {
        //randomTime -= Time.deltaTime;
        //tekst.text = randomTime.ToString("f3");
        //tekst.text
        //Delay();
        //Debug.Log(randomTime);
    }
}
