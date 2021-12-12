using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject game;
    public TextMeshProUGUI pointsText;

    public void Setup(int score){
       game.SetActive(true);
       pointsText.text = score + " POINTS";
   }

   public void RestartButton(){
    //    ScoreCounter.UpdateHighScore();
    //    ScoreCounter.highScore = ScoreCounter.Counter;
       ScoreCounter.Counter = 0;
       ScoreScript.snowballs = 15;
       SceneManager.LoadScene("MyGame");
   }
   public void ExitButton(){
       
       ScoreCounter.Counter = 0;
       ScoreScript.snowballs = 15;
       
       SceneManager.LoadScene("Menu");
   }
}
