using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DestroyScript : MonoBehaviour {

public static int berry = 0;
public static int honey = 0;
public static int fish = 0;
public static int score = 0;

public static int Key = 0;


public Text Objective;


	void OnTriggerEnter(Collider TheCollision){
		if(TheCollision.tag == "Player"){
				if(gameObject.tag == "berry"){
					berry++;
					Objective.text = "Berries: " + DestroyScript.berry;
				}
				if(gameObject.tag == "honey"){
					honey++;
					Objective.text = "Honey: " + DestroyScript.honey;
				}
				if(gameObject.tag == "key"){
					Key++;
				}
				if(gameObject.tag == "fish"){
					fish++;
					Objective.text = "Fish: " + DestroyScript.fish;
				}



				Destroy(gameObject);




		}
	}

	
}

