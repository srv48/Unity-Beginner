using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupControl : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (30, 30, 45) * Time.deltaTime);
		
	}
}
