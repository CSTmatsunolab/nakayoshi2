using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class CountText : MonoBehaviour
{
    int score = 0;
    public int Score{
            get{ return this.score; }  //取得用
            private set{ this.score = value; }　//値入力用
    }

    public Text scoreText;
 
    public void AddScore()
    {
        score++;
    }
 
    void Update()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }
}

