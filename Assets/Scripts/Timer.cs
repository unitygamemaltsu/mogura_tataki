using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public Text TimerText;
    private float timer;
    int seconds;

    
    //private float totalTime;
    // Use this for initialization
    void Start () {
        //StartReset();
        //timer = 30.0f;
        timer = 5.0f;//debugmode
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        seconds = (int)timer;
        TimerText.text = seconds.ToString();
        if(seconds <= 0){
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
        }
    }



}
