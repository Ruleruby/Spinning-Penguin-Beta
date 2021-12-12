using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    // public void quitGame()
    // {
    //     Application.Quit(); //Quit Game
    // }
    public void openSourceCode(){
        //Opens code in GitHub
        Application.OpenURL("https://github.com/Ruleruby/Spinning-Penguin");
    }

    public void openWebGL(){
        Application.OpenURL("https://ruleruby.github.io/Spinning-Penguin/");
    }

}
