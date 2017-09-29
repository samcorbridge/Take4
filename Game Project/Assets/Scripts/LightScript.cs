using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LightScript : MonoBehaviour {



	public float theDistance;
	RaycastHit Hit;
	public Transform target;
	public Transform MoveMe;
	public float speed;
	void Start () {

	}
	
	void Update () {
		Vector3 pointMe = transform.TransformDirection(Vector3.forward) * 10;
			Debug.DrawRay(transform.position, pointMe, Color.green);

		if(Physics.Raycast(transform.position,(pointMe), out Hit, 10)){
			theDistance = Hit.distance;
			if(Hit.transform.tag == "score"){
				float step = speed * Time.deltaTime;
        		MoveMe.transform.position = Vector3.MoveTowards(MoveMe.transform.position, target.position, step);
			}


		}


	}

}

