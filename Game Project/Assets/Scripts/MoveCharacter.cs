using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))]

public class MoveCharacter : MonoBehaviour {


	CharacterController cc;
	Vector3 tempMove; //coordinate in 3d space.
	float speed;
	float gravity;
    float jumpHeight;
	public static int jumpnum = 0;
	public float runspeed = 20;
	public float normalspeed = 10;
	public bool UpDown = true;
	public bool underwater = false;
	Vector3 tempPos;  
    void Start () {
		cc = GetComponent<CharacterController>();
		MoveInputs.JumpAction = Jump;
		MoveInputs.KeyAction += Move;
		MoveInputs.ZeldaAction += Zelda;
		MoveInputs.ZeldaTWO = Zelda2;
		MoveInputs.ZeldaTHREE = Zelda3;
		// RespawnScript.Recenter = Centering;
		MoveInputs.ZeldaFour = Zelda4;
		Water.SendSpeed = WaterMovement;
		speed = 10;
		gravity = StaticVars.gravity;
		Mud.InMud = InMud;
		jumpHeight = 0.35f;
	}
	void Jump () {
		if(cc.isGrounded || jumpnum < 1 || (underwater == true)){
			tempMove.y = jumpHeight;
			jumpnum++;
			if(cc.isGrounded ){
				jumpnum = 0;
			}
		}
	}
	private void WaterMovement(float _speed, float _gravity, bool _jumping){
		speed = _speed;
		gravity = _gravity;
		underwater = _jumping;
		jumpnum = 0;
	}
	void Move (float _movement){
		if(cc.isGrounded == true){
			gravity = 0;
		}
		else if (underwater == true){
			gravity = StaticVars.waterGravity;
		}
		else {
			gravity = StaticVars.gravity;
		}
				if(Input.GetKeyDown(KeyCode.LeftShift) && cc.isGrounded && (underwater == false)){
					speed = StaticVars.RunSpeed;

				}
				if(Input.GetKeyUp(KeyCode.LeftShift) && (underwater == false)){
					speed = StaticVars.playerSpeed;
				}
		tempMove.y -= gravity * Time.deltaTime;
		tempMove.x = _movement*speed*Time.deltaTime;
		cc.Move(tempMove);		
	}
	void Zelda (float _moving){
		tempMove.z = _moving*speed*Time.deltaTime;
	}
	void Zelda2 ()
	{

				tempPos = transform.position;
				tempPos.z = 1;
				transform.position = tempPos;		
	}
	void Zelda3 ()
	{
				tempPos = transform.position;
				tempPos.z = 0;
				transform.position = tempPos;		
	}
	void Zelda4 (){
				tempPos = transform.position;
				tempPos.z = -1;
				transform.position = tempPos;
	}
	// void Centering(){
	// 	UpDown = true;
	// }
	void InMud (float _jumpheight, float _runspeed){
		jumpHeight = _jumpheight;
		speed = _runspeed;
	}
}
