using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2ButtonScript : MonoBehaviour {

	public GameObject thisObject;

	private void OnMouseDown()
	{
		SceneManager.LoadScene("level2Scene");
	}

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("level") > 1)
		{
			thisObject.SetActive(true);
		}
		else
		{
			thisObject.SetActive(false);
		}
	}
	
	
}
