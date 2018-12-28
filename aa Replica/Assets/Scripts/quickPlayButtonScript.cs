using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quickPlayButtonScript : MonoBehaviour {

	private void OnMouseDown()
	{
		SceneManager.LoadScene("quickPlayScene");
	}
}
