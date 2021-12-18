using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float minutes;
    public float seconds;

    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameTimer();
    }

    public void GameTimer()
    {
        if (GameManager.leben >= 0)
        {
            minutes = Time.timeSinceLevelLoad / 60;


            seconds = Time.timeSinceLevelLoad % 60;
            Mathf.FloorToInt(seconds);

            if ((minutes < 10) && (seconds < 10))
            {
                timerText.text = "0" + Mathf.FloorToInt(minutes).ToString() + ":" + "0" + Mathf.FloorToInt(seconds);
            }
            else if ((minutes < 10) && (seconds >= 10))
            {
                timerText.text = "0" + Mathf.FloorToInt(minutes).ToString() + ":" + Mathf.FloorToInt(seconds);
            }
            else if ((minutes >= 10) && (seconds < 10))
            {
                timerText.text = Mathf.FloorToInt(minutes).ToString() + ":" + "0" + Mathf.FloorToInt(seconds);
            }

        } else if (GameManager.leben < 0)
        {
            timerText.CrossFadeColor(Color.black, 2.0f, true, true);
        }

        

    }
}
