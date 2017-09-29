using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
public Text Deathtext;


void Start()
	{
		RespawnScript.deathcount = Dying;
		print("hey hey");
	 	Deathtext.text = "Deaths: " + RespawnScript.deaths;

	}
	void Dying(){
	}
}
