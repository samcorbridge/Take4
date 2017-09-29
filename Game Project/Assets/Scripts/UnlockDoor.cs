using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UnlockDoor : MonoBehaviour {

	void OnTriggerEnter(Collider TheCollision){
		if(TheCollision.tag == "Player"){
			if(DestroyScript.Key != 0)
							Destroy(gameObject);
		}
	}
}
