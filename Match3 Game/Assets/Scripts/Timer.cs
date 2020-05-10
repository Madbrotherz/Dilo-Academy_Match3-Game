using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    public float startTime = 10f;
    public bool timesUp = false;
    public GameObject pausePanel;

    public Text CountDownText;
    void Start()
    {
        currentTime = startTime;
        timesUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0 && !timesUp)
        {
            currentTime -= 1 * Time.deltaTime;
            print(currentTime);
            CountDownText.text = currentTime.ToString("0");
            if (currentTime <= 0)
            {
                gameOver();
            }
        }

        if (currentTime >= 3.5f) { CountDownText.color = Color.black; }
        if (currentTime < 3.5f) { CountDownText.color = Color.red; }


    }

    public void gameOver()
    {
        Time.timeScale = 0;
        timesUp = true;
        pausePanel.SetActive(true);
    }
}
