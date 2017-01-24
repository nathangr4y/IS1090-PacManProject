using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Rigidbody pacman;

	public Text scoreDisplay;
	public int score;

	public Text lifeDisplay;
	public int life;

	public Rigidbody gameOver;

	//intializes player, score, life
	void Start () {
		pacman = GetComponent<Rigidbody> ();
		score = 0;
		scoreDisplay.text = "Score: " + score;
		life = 3;
		lifeDisplay.text = "Life: " + life;
	}


	//player control loop
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 playerMove = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		pacman.AddForce (playerMove * speed);

	}


	//coin collector loop
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Coin")) 
		{
			other.gameObject.SetActive (false);
			score++;
			scoreDisplay.text = "Score: " + score;
		}
	}
		

	//ghost collision loop & game over
	void OnCollisionEnter(Collision col)
	{
		Vector3 start = new Vector3 (0.0f, 0.5f, -1.5f);

		if (col.collider.tag == "Ghost" && life != 0)
		{
			transform.position = start;
			life--;
			lifeDisplay.text = "Life: " + life;

			print ("Life: " + life);
		} else if (life == 0)
		{
			pacman.gameObject.SetActive (false);
			gameOver.gameObject.SetActive (true);
		}
	}
}