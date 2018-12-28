using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetRoationScript : MonoBehaviour {

	public float rotationSpeed = 70f;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
	}
}
