using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeKinematic : MonoBehaviour {

public Rigidbody RB;
	void OnTriggerEnter(Collider Drop){
		if(Drop.tag == "Block"){
				RB.isKinematic = true;

			

	

		}
	}
}
