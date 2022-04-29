using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerToSad : MonoBehaviour
{
    public float timer = 2.0f;
    public float timeToScn1 = 15.0f, timeToScn2 = 45.0f, timeToScn3 = 75.0f, timeToScn4 = 105.0f;

    //bool esc_Activate;
    //bool esc_HierarchyOutput;
    public GameObject allMadObjects;
    public GameObject esc_Object;

    bool loadNewScene1 = true;
    bool loadNewScene2 = true;
    bool loadNewScene3 = true;
    bool loadNewScene4 = true;

    void Awake()
    {
        Time.timeScale = 1; //game time speed = real time speed

    }



    void Update()
    {

        //pause the game + load the sad scene

        if (esc_Object.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            timer += Time.deltaTime;
        }

        if (timer >= timeToScn1 && loadNewScene1)
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Additive);
            loadNewScene1 = false;
        }

        if (timer >= timeToScn2 && loadNewScene2)
        {
            SceneManager.LoadScene("Main4", LoadSceneMode.Additive);
            loadNewScene2 = false;
        }

        if (timer >= timeToScn3 && loadNewScene3)
        {
            SceneManager.LoadScene("Main6", LoadSceneMode.Additive);
            loadNewScene3 = false;
        }

        if (timer >= timeToScn4 && loadNewScene4)
        {
            SceneManager.LoadScene("Main7", LoadSceneMode.Additive);
            loadNewScene4 = false;
        }


    }
}