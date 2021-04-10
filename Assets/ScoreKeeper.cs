using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    public Text ScoreText;
    int score = 0;
    public void Scorer(int value)
    {
        score = score + value;
        ScoreText.text = score.ToString();
        if(score == 100)
        {
            SceneManager.LoadScene(2);
        }
    }
}
