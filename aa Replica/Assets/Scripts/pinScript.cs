using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pinScript : MonoBehaviour {

	public float flySpeed = 20f;

	private Rigidbody2D pinBody;
	private bool shouldFly;

	// Use this for initialization
	void Start () {
		shouldFly = true;
		pinBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(shouldFly == true)
		{
			//make our pin fly
			pinBody.MovePosition(pinBody.position + Vector2.up * flySpeed * Time.deltaTime);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "target")
		{
			//if the pin collides with the target we want to make it stop and snap to the target
			shouldFly = false;
			transform.SetParent(collision.gameObject.transform);

		}
		else if(collision.tag == "pin")
		{
			//if the pin collides with another pin, it's game over
			SceneManager.LoadScene("quickGameOverScene");
		}
	}
}
