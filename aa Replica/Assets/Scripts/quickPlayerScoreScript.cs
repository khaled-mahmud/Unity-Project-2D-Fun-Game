using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quickPlayerScoreScript : MonoBehaviour {

	public GameObject score;
	private TextMesh scoreText;
	public static int scoreValue;

	// Use this for initialization
	void Start () {
		scoreText = score.GetComponent<TextMesh>();
		scoreValue = 0;
		PlayerPrefs.SetInt("currentScore", 0);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "pin")
		{
			scoreValue++;
			scoreText.text = System.Convert.ToString(scoreValue);
			PlayerPrefs.SetInt("currentScore", scoreValue);
		}
	}
}
