using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreSystem : MonoBehaviour
{
    public TMP_Text scoreText;
    public int highscore;

    public static int score = 0;

    public void scored(){
        score += 1;
        scoreText.SetText(score.ToString());
         highscore = (int)score;
        scoreText.text = highscore.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        scoreText.text = score.ToString();
        //  if(PlayerPrefs.GetInt("score")<=highscore)
        // PlayerPrefs.SetInt("score", highscore);
        
        // scoreText.text = PlayerPrefs.GetInt("score").ToString();
        
    }
    // public void highscorefun(){
    //      if(PlayerPrefs.GetInt("score")<=highscore)
    //     PlayerPrefs.SetInt("score", highscore);
    //     scoreText.text = PlayerPrefs.GetInt("score").ToString();
    // }
    // Update is called once per frame
    void Update()
    {
      
        
    }
}
