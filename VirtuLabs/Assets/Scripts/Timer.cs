using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    int timeRemaining = 30;
    Text timeDisplay;
    void Start()
    {
        timeDisplay = GetComponent<Text>();
        timeDisplay.text = timeRemaining.ToString();
        UpdateTime();
    }

    public void UpdateTime()
    {
        if (timeRemaining > 0)
        {
            timeRemaining = timeRemaining - 1;
            timeDisplay.text = timeRemaining.ToString();
            Invoke("UpdateTime", 1f);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
