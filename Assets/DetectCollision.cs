using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public int myscorevalue;
    private void OnCollisionEnter(Collision collision)
    {
        ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
        scoreKeeper.Scorer(myscorevalue);
    }
}
