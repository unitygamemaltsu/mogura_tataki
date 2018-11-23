using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
　  public AudioClip[] clips;
    AudioSource audio;
    public static int lebel = 8;//確認用
    //public static int lebel = 2;
    public static int getLebel(){
        return lebel;
    }

    public static void setLebel(int val) {
        lebel = val;
    }
    // public void Setlevel(float setVal) {
    //     Lebelchange = setVal;
    // }

    public void ReplayGame()
    {
        audio = GetComponent<AudioSource>();
		audio.clip = clips[0];
        audio.Play();
        SceneManager.LoadScene("MainScene");
    }

    

}