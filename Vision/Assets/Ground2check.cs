using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground2check : MonoBehaviour
{
	public bool Grounded2;

	void OnTriggerStay2D(Collider2D col)
	{ //if the groundcheck is inside the ground or an object with a collider
		Grounded2 = true;
	}


	void OnTriggerExit2D(Collider2D col)
	{ //if the groundcheck is NOT inside the ground or an object with a collider
		Grounded2 = false;
	}
}
