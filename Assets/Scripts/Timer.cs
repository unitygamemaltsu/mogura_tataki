using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    private float timer;
    int seconds;


    //private float totalTime;
    // Use this for initialization
    void Start()
    {
        //StartReset();
        timer = 30.0f;
        //timer = 5.0f;//debugmode
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        seconds = (int)timer;
        TimerText.text = seconds.ToString();
        if (seconds <= 0)
        {
            int lebel = StartGame.getLebel();
            Debug.Log("レベル: " + lebel);
            if (StartGame.upScores[lebel - 1] <= Score.Instance.score)
            {
                StartGame.upLebel();
            }

            // if (StartGame.getSpeed() <= 2)
            // {
            //     StartGame.setSpeed(8);
            // } else {
            //     int setLebel = StartGame.getSpeed() - 2;
            //     StartGame.setSpeed(setLebel);
            // }

            SceneManager.LoadScene("ResultScene");

            if (StartGame.getLebel() == 1)//多分レベルアップ後値が参照されているつまりこれ意味なし
            {
                if (Score.Instance.score <= 10)
                {
                    SceneManager.LoadScene("ResultScene2");
                }
                else
                {
                    SceneManager.LoadScene("ResultScene");
                }
            }

            else if (StartGame.getLebel() == 2)
            {
                if (Score.Instance.score <= 20)
                {
                    SceneManager.LoadScene("ResultScene2");
                }
                else
                {
                    SceneManager.LoadScene("ResultScene");
                }
            }

            else if (StartGame.getLebel() == 3)
            {
                if (Score.Instance.score <=30 )
                {
                    SceneManager.LoadScene("ResultScene2");
                }
                else
                {
                    SceneManager.LoadScene("ResultScene");
                }
            }
            else if (StartGame.getLebel() == 4)
            {
                if (Score.Instance.score <= 35 )
                {
                    SceneManager.LoadScene("ResultScene2");
                }
                else
                {
                    SceneManager.LoadScene("ResultScene3");
                }
            }
        }
    }



}
