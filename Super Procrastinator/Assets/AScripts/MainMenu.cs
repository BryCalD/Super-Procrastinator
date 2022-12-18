using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private ScoreManager theScoreManager;

   void Start()
    {
        Time.timeScale = 0f;
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void Update()
    {
    bool restart = Input.GetKeyDown(KeyCode.R);
     if (restart)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(0);
            theScoreManager.scoreCount = 0;
            theScoreManager.scoreIncrease = true;
        }
    }
}

        
        

