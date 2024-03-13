using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer : MonoBehaviour
{
    public static pointer instance;

    public int number;

    void Start()
    {
        GetComponent<BoxCollider>().enabled = false;
    }

    void Update()
    {
        if (mainScript.instance.Speed < 15 && mainScript.instance.Speed > 1)
        {
            GetComponent<BoxCollider>().enabled = true;
        }
    }

    public void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log ("Wygrywaj¹ca liczba: " + col.gameObject.name);
        number = int.Parse (col.gameObject.name);
    }

}
