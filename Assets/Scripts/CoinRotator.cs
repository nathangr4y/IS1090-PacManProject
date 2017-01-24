using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotator : MonoBehaviour {
	public float speed;

	// Update is called once per frame
	void Update () {
		Vector3 rotation = new Vector3(speed*15, speed*30, speed*45);
		transform.Rotate(rotation * Time.deltaTime);
	
	}
}
