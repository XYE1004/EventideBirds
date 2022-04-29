using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeCountDown : MonoBehaviour
{
    //Test
    float timer = 0.0f;
    public GameObject clockSpeedUp;

    void Start()
    {
        clockSpeedUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5.5f)
        {
            clockSpeedUp.SetActive(true);
        }
    }
}