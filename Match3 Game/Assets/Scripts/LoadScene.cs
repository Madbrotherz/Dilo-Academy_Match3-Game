using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject resumeBtn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Loadscenes(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void ExitGame() {
        Application.Quit();
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        resumeBtn.SetActive(false);
    }
}
