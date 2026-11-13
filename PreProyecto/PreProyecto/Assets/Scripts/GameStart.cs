using System;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    [SerializeField] private String printLog;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log(printLog);
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
