using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DropScript : MonoBehaviour {

public float time;
public Rigidbody RB;

	void OnTriggerEnter(Collider Drop){
		if(Drop.tag == "Player"){
				// Destroy(gameObject);
				StartCoroutine(Waiting());
			

	

		}
	}

		 IEnumerator Waiting()
    {
        print("Before");
        yield return new WaitForSeconds(time);
				RB.isKinematic = false;
        print("After");
    }
}

