using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {
    public AudioClip[] clips;
    AudioSource audio;

	private 
	// Use this for initialization
	void Start () {
        
		audio = GetComponent<AudioSource>();
		//audio.clip = clips[0];
        //audio.Play();
		if(StartGame.getLebel() == 1){
		audio.clip = clips[0];
        audio.Play();
		}
		if(StartGame.getLebel() == 2){
		audio.clip = clips[1];
        audio.Play();
		}
		if(StartGame.getLebel() == 3){
		audio.clip = clips[2];
        audio.Play();
		}
		if(StartGame.getLebel() == 4){
		audio.clip = clips[2];
        audio.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
