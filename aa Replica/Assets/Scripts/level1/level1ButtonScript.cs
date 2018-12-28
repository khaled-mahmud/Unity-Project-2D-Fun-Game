using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1ButtonScript : MonoBehaviour {

	private void OnMouseDown()
	{
		SceneManager.LoadScene("level1Scene");
	}
}
