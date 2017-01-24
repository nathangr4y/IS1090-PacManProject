using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour {
	public float speed;

	public Rigidbody ghost;
	public Rigidbody wall; 
	public Rigidbody node;

	public float ghostHorizontal = 1.0f;
	public float ghostVertical = 0.0f;

	float alt; 
	float temp;


	//initialize
	void Start () 
	{
		ghost = GetComponent<Rigidbody> ();
		wall = GetComponent<Rigidbody> ();
		node = GetComponent<Rigidbody> ();
	}


	//ghost movement
	void FixedUpdate () 
	{
		Vector3 ghostMove = new Vector3 (ghostHorizontal, 0.0f, ghostVertical);
		ghost.AddForce (ghostMove * speed);

		//checks for stuck ghosts
		if (ghost.velocity.magnitude < 0.12f) {
			temp = -ghostHorizontal;
			ghostHorizontal = ghostVertical;
			ghostVertical = temp;
		}
	}


	//change movement upon collision with nodes || ghosts

	void OnCollisionEnter(Collision col)
	{
		alt = Mathf.Pow (-1, Random.Range (1, 2));

		if (col.collider.tag == "NodeDown") {
			ghostHorizontal = 0.0f;
			ghostVertical = -1.0f;
		} else if (col.collider.tag == "NodeUp") {
			ghostHorizontal = 0.0f;
			ghostVertical = 1.0f;
		} else if (col.collider.tag == "NodeLeft") {
			ghostHorizontal = -1.0f;
			ghostVertical = 0.0f;
		} else if (col.collider.tag == "NodeRight") {
			ghostHorizontal = 1.0f;
			ghostVertical = 0.0f;
		} else if (col.collider.tag == "Ghost") {
			if (ghostHorizontal == 1.0f || ghostHorizontal == -1.0f) {
				ghostHorizontal = -ghostHorizontal;
			} else if (ghostVertical == 1.0f || ghostVertical == -1.0f) {
				ghostVertical = -ghostVertical;
			}
		} else if (col.collider.tag == "NodeT_lr") {
			ghostHorizontal = alt * 1.0f;
			ghostVertical = 0.0f;
		} else if (col.collider.tag == "NodeT_ud") {
			ghostHorizontal = 0.0f;
			ghostVertical = alt * 1.0f;
		}
	}
}

