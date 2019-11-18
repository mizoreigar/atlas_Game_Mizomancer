using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score_Counter : MonoBehaviour
{
	public static int score_Value = 0;
	
  public static int score=0;
  int highscore;
  int highscoresave;

  public Text scoreText;
  public Text highscoreText;


    void Start(){
        highscore=PlayerPrefs.GetInt("highscoresave",highscore);
	    	scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update(){
        scoreText.text = "" + score;
        //highscoreText.text = "Record: " + highscore;
           // if(score>highscore){
             //   highscore=score;
              //  PlayerPrefs.SetInt("highscoresave",highscore);
           // }
    }
}
