using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PatrollingEnemy : MonoBehaviour {

private NavMeshAgent agent;
private Transform towardsMe;
public Transform InitialTowards;


	void Start(){
		agent = GetComponent<NavMeshAgent>();
		towardsMe = InitialTowards;
		Switch.newLocation = newLocationHandler;
	}
	void Update(){	
			agent.destination = towardsMe.position;
	}


	void newLocationHandler(Transform _newLocation){
		towardsMe = _newLocation;
	}

}
