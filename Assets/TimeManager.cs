using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    float time = 10.0f;
    public Text timetext;

    private void Update()
    {
        time -= Time.deltaTime;
        timetext.text = Mathf.RoundToInt(time).ToString();
        if(time<=0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
