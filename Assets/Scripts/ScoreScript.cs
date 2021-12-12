using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI SnowballText;
    public GameOverScreen GameOverScreen;
    public ScoreCounter Counter;
    public static int snowballs = 15;
    private float delayBeforeLoading = 3f;
    private float timeElapsed;



   
    // Start is called before the first frame update
    void Start()
    {
        SnowballText.text = "Snowballs x 15";

    }
    void Update()
    {
        if(snowballs > 0){
            if (Input.GetButtonDown("Fire1"))
            {
                snowballs = snowballs - 1;
            }
            SnowballText.text = "Snowballs x " + snowballs;

        } 
        else{
            timeElapsed += Time.deltaTime;
            if(timeElapsed > delayBeforeLoading){
                GameOverScreen.Setup(ScoreCounter.Counter);
            }
        }
    }
    
}

    

