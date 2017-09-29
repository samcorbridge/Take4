using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {

	public float speed = 10;
	public float gravity = 5;
	public float waterSpeed = 5;
	public float waterGravity = 2;
	// public float waterFloat = -1;
	public float RunSpeed = 20;
	public float JumpHeight = 0.35f;
	// public bool waterBerry;


	void Start(){
		StaticVars.playerSpeed = speed;
		StaticVars.gravity = gravity;
		StaticVars.waterSpeed = waterSpeed;
		StaticVars.waterGravity = waterGravity;
		StaticVars.RunSpeed = RunSpeed;
		StaticVars.JumpHeight = JumpHeight;
		// StaticVars.waterFloat = waterFloat;
		// StaticVars.waterBerry = waterBerry;
	}
}
