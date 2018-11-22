using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
　  public AudioClip[] clips;
    AudioSource audio;
    public static float lebel = 0.8f;

    public static float getLebel(){
        return lebel;
    }

    public static void setLebel(float val) {
        lebel -= val;
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