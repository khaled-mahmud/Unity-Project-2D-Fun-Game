using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinSpawnerScript : MonoBehaviour {

	public GameObject pinPrefab;
	public GameObject location;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(pinPrefab, location.transform.position, location.transform.rotation);
		}
	}


}
