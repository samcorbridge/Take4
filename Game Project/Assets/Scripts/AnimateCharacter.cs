using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AnimateCharacter : MonoBehaviour {

Animator anims;

	// Use this for initialization
	void Start () {
		anims = GetComponent<Animator>();
		PlayButton.Play += OnPlay;
	}

	void OnPlay () {
		MoveInputs.KeyAction += Animate;
		anims.SetTrigger("IsLoaded");
		PlayButton.Play -= OnPlay;
	}

private void Animate(float obj)
{
	anims.SetFloat("Walk", obj);
}

}
