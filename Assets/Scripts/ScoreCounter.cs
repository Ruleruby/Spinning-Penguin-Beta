using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{


    public static int Counter = 0;
    public static int highScore = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    // Start is called before the first frame update
    void Start()
    {
         scoreText.text = "Score = 0";
         highScoreText.text = "HighScore = 0";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score = " + Counter;
        highScoreText.text = "HighScore = " + highScore;
        if(Counter > highScore){
            highScore = Counter;
            highScoreText.text = "HighScore = " + highScore;
        }
    }
}
    // public static void UpdateHighScore(){
    // if(Counter > highScore){
    //         highScore = Counter;
    //         highScoreText.text = "HighScore = " + highScore;
    //     }
    // }
// }
