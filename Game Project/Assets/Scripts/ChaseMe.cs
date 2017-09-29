using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChaseMe : MonoBehaviour {
	public static Action<Transform> newLocation;
	public Transform newSpot;
	public Transform ReturnSpot;

	void OnTriggerStay()
	{
		newLocation(newSpot);
		
	}
}
