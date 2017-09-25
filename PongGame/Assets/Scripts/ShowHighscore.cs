using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHighscore : MonoBehaviour {

	public TextMesh highScore;
	// Use this for initialization
	void Start () {
		highScore.text = "Survival Highscore: " + PlayerPrefs.GetInt ("High Score");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
