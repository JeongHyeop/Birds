using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {   
    public Text bestScoreLabel;
    public Text scoreLabel;

    int score = 0;
    int bestScore = 0;
    	
	void Start () {
        DisplayScore(0);
        DisplayBestScore();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void DisplayScore(int _score)
    {
        score += _score;
        scoreLabel.text = "SCORE: " + score.ToString();
    }
    public void SetBestScore()
    {
        bestScore = PlayerPrefs.GetInt("BESTSCORE", bestScore);

        if (bestScore == 0)
        {
            PlayerPrefs.SetInt("BESTSCORE", score);
        }
        else if (bestScore > score)
        {
            PlayerPrefs.SetInt("BESTSCORE", bestScore);
        }
        else if(bestScore < score){
            PlayerPrefs.SetInt("BESTSCORE", score);
        }
        else
        {
            PlayerPrefs.SetInt("BESTSCORE", bestScore);
        }
    }
    public void DisplayBestScore()
    {
        bestScore = PlayerPrefs.GetInt("BESTSCORE", bestScore);
        bestScoreLabel.text = "BEST: " + bestScore.ToString();
    }
}
