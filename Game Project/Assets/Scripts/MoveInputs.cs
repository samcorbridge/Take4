using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveInputs : MonoBehaviour {

	public float runTime = 0.01f;
	public static Action<float> KeyAction;	
	public static Action JumpAction;

	public bool canPlay = true;

	public static Action<float> ZeldaAction;

	public static Action ZeldaTWO;
	public static Action ZeldaTHREE;
	public static Action ZeldaFour;
	void Start(){
		StartCoroutine(RunInput());
		// RespawnScript.StopMove = FREEZE;
		// RespawnScript.StartMove = GO;
	}

	IEnumerator RunInput() 
	{
		while (canPlay == true){
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
		{
			JumpAction();
		}

		if (ZeldaAction != null)
		{
			ZeldaAction(Input.GetAxis("Vertical"));
		}

		if (Input.GetKeyDown(KeyCode.W)){
			ZeldaTWO();
		} 
		if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)){
			ZeldaTHREE();
		}
		if (Input.GetKeyDown(KeyCode.S)){
			ZeldaFour();
		}

	
		if (KeyAction != null)
		{
			KeyAction(Input.GetAxis("Horizontal"));
		}
		yield return new WaitForSeconds(runTime);
		}
	}

	// void GO (){
	// 	canPlay = true;
	// 	Invoke("Start", 0);
	// }
	// void FREEZE (){
	// 	canPlay = false;
	// }
}