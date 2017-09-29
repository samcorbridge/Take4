using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WallJump : MonoBehaviour {


		void OnTriggerEnter(Collider boom)
	{
		if(boom.tag == "Player")
		{
				MoveCharacter.jumpnum = -1;
		}
	}	
}


