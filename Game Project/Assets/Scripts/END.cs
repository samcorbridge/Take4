using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END : MonoBehaviour {

public string scene;
void OnTriggerEnter(Collider TheCollision){
		if(TheCollision.tag == "Player"){
		SceneManager.LoadScene(scene, LoadSceneMode.Single);
		}
	}
}
