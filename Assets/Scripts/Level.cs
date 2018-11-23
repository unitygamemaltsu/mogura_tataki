using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour {

    // レベル表示
    public Text levelText;
    void Start()
    {
        levelText.text = StartGame.getLevel().ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
