using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class LoadScript : MonoBehaviour {

	public string scene;

	public static Action EndButtons;

	void start(){
		LoadScript.EndButtons += EndThis;
	}

	private void EndThis(){
		GetComponent<Button>().interactable = false;
	}

	public void LoadLevel () {
		SceneManager.LoadScene(scene, LoadSceneMode.Single);
		EndButtons();
	}
}
