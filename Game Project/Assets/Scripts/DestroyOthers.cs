using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOthers : MonoBehaviour {

	public GameObject ThingToBust;

	void OnTriggerEnter(Collider ME){
		if(ME.tag == "Player"){
			
				Destroy(ThingToBust);
			

	

		}
	}
}
