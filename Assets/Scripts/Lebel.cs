using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lebel : MonoBehaviour {

    // レベル表示
    public Text lebelText;
	void Start () {
        lebelText.text = StartGame.getLebel().ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
