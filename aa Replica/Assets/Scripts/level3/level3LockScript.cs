using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3LockScript : MonoBehaviour
{

	public GameObject thisObject;

	// Use this for initialization
	void Start()
	{
		if (PlayerPrefs.GetInt("level") < 3)
		{
			thisObject.SetActive(true);
		}
		else
		{
			thisObject.SetActive(false);
		}
	}
}
