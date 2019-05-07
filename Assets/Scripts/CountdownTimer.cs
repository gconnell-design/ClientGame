using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float currentTime = 30f;
    public float startingTime = 30f;
    public Text timerTxt;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerTxt.text = currentTime.ToString ("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
        }

    }
}
