using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    public int health;
    public int myscorevalue;
   

    private void Start()
    {
        
    }
    private void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
        scoreKeeper.Scorer(myscorevalue);
        if (collision.gameObject.tag == "Bullet");
        {
            health--;
            
            if (health <= 0)
            {
                Destroy(gameObject);
                
            }
            
        }
        
    }
}
