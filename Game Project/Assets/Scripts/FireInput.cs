using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class FireInput : MonoBehaviour {

public static Action FireAction;
public static Action StopAction;

public void Fire(){
	FireAction();
}

public void stop (){
	StopAction();
}
}
