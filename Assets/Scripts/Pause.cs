using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseScreen;
    bool GamePaused;

    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GamePaused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    public void pauseGame()
    {
        GamePaused = true;
        pauseScreen.SetActive(true);
    }

    public void ResumeGame()
    {
        GamePaused = false;
        pauseScreen.SetActive(false);
    }

    public void ExitButton()
    {
        ScoreCounter.Counter = 0;
        ScoreScript.snowballs = 15;
        SceneManager.LoadScene("Menu");
    }


}
