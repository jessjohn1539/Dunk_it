using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class highscore : MonoBehaviour
{
    public TMP_Text ScoreText;
    public static int score = 0;
// public int = ScoreSystem.score

    // Start is called before the first frame update
    void Start()
    {
        // ScoreSystem.score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
        ScoreText.SetText(ScoreSystem.score.ToString());
        // ScoreSystem.score = 0;
    }

}
