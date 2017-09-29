using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyScript : MonoBehaviour {

	public float speed;
	public Transform target;	
	void Start () {
			// LightScript.Moving = Movetowards;	
	}
	void Movetowards (){
			print("shouldbemoving?");
		float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}

}
