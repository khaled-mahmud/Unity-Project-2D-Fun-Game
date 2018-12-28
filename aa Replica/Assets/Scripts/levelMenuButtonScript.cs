using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelMenuButtonScript : MonoBehaviour {

	private void OnMouseDown()
	{
		SceneManager.LoadScene("levelMenuScene");
	}
}
