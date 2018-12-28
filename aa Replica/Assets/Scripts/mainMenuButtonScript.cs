using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuButtonScript : MonoBehaviour {

	private void OnMouseDown()
	{
		SceneManager.LoadScene("homeScene");
	}
}
