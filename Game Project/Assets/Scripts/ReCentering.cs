using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ReCentering : MonoBehaviour {
Vector3 tempPos;
public Transform player;

void OnTriggerEnter(Collider TheCollision){


		if(TheCollision.tag == "Player" && Input.GetKey(KeyCode.W)){
			print("Not Centering");
		} else if (TheCollision.tag == "Player"){
				tempPos = player.transform.position;
				tempPos.z = 0;
				player.transform.position = tempPos;
			}

		}
		
	}


