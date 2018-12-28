using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1TargetScript : MonoBehaviour
{

	public GameObject score;
	private TextMesh scoreText;
	public static int scoreValue;

	// Use this for initialization
	void Start()
	{
		scoreText = score.GetComponent<TextMesh>();
		scoreValue = 0;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "pin")
		{
			scoreValue++;
			scoreText.text = System.Convert.ToString(scoreValue);

			if(scoreValue == 20)
			{
				if (PlayerPrefs.GetInt("level") < 2)
				{
					PlayerPrefs.SetInt("level", 2);
				}
				SceneManager.LoadScene("levelSuccessScene");
			}

		}
	}
}

