using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawnPlatforms : MonoBehaviour {

Vector3 tempPos;
public Transform ReAppearSpot;
public Transform Block;
public Rigidbody Rigy;
void OnTriggerEnter(Collider Drop){
	if(Drop.tag == "Platform"){
		StartCoroutine(JumpUp());

			}
		}

		IEnumerator JumpUp (){
			print("before");
			yield return new WaitForSeconds(5);
		Block.transform.position = ReAppearSpot.transform.position;
		Block.transform.rotation = ReAppearSpot.transform.rotation;
		Rigy.isKinematic = true;

		}
	}
	



