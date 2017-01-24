using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinCreator : MonoBehaviour {

	public Rigidbody Coin;
	public Rigidbody Wall;

	List<float> posX = new List<float>();
	List<float> posZ0 = new List<float>();
	List<float> posZ1 = new List<float>();
	List<float> posZ2 = new List<float>();
	List<float> posZ3 = new List<float>();
	List<float> posZ4 = new List<float>();

	float coordX;
	float coordZ;


	void Start () 
	{
		//create lists of allowable individual coords
		posX.Add (-9.5f);
		posX.Add (-7.5f);
		posX.Add (-5.5f);
		posX.Add (-3.5f);
		posX.Add (-1.5f);
		posX.Add (1.5f);
		posX.Add (3.5f);
		posX.Add (5.5f);
		posX.Add (7.5f);
		posX.Add (9.5f);

		posZ0.Add (-9.5f);
		posZ0.Add (-5.5f);
		posZ0.Add (-2.5f);
		posZ0.Add (3.5f);
		posZ0.Add (5.5f);
		posZ0.Add (9.5f);

		posZ1.Add (-9.5f);
		posZ1.Add (-7.5f);
		posZ1.Add (-5.5f);
		posZ1.Add (-2.5f);
		posZ1.Add (-0.5f);
		posZ1.Add (1.5f);
		posZ1.Add (3.5f);
		posZ1.Add (5.5f);
		posZ1.Add (7.5f);
		posZ1.Add (9.5f);

		posZ2.Add (-9.5f);
		posZ2.Add (-5.5f);
		posZ2.Add (-2.5f);
		posZ2.Add (-0.5f);
		posZ2.Add (3.5f);
		posZ2.Add (5.5f);
		posZ2.Add (7.5f);
		posZ2.Add (9.5f);

		posZ3.Add (-9.5f);
		posZ3.Add (-7.5f);
		posZ3.Add (-5.5f);
		posZ3.Add (-2.5f);
		posZ3.Add (-0.5f);
		posZ3.Add (2.5f);
		posZ3.Add (5.5f);
		posZ3.Add (7.5f);
		posZ3.Add (9.5f);

		posZ4.Add (-9.5f);
		posZ4.Add (-7.5f);
		posZ4.Add (-4.5f);
		posZ4.Add (-2.5f);
		posZ4.Add (2.5f);
		posZ4.Add (4.5f);
		posZ4.Add (7.5f);
		posZ4.Add (9.5f);

		for (int i = 0; i < 15; i++) 
		{
			coordX = posX [Random.Range (0, 10)];

			//create allowable coordinate combinations
			if (coordX == -9.5) {
				coordZ = posZ0 [Random.Range (0, 6)];
			} else if (coordX == 9.5) {
				coordZ = posZ0 [Random.Range (0, 6)];
			} else if (coordX == -7.5) {
				coordZ = posZ1 [Random.Range (0, 10)];
			} else if (coordX == 7.5) {
				coordZ = posZ1 [Random.Range (0, 10)];
			} else if (coordX == -5.5) {
				coordZ = posZ2 [Random.Range (0, 8)];
			} else if (coordX == 5.5) {
				coordZ = posZ2 [Random.Range (0, 8)];
			} else if (coordX == -3.5) {
				coordZ = posZ3 [Random.Range (0, 9)];
			} else if (coordX == 3.5) {
				coordZ = posZ3 [Random.Range (0, 9)];
			} else if (coordX == -1.5) {
				coordZ = posZ4 [Random.Range (0, 8)];
			} else if (coordX == 1.5) {
				coordZ = posZ4 [Random.Range (0, 8)];
			}


			//generate coins at coords
			Vector3 pos = new Vector3 (coordX, 0.6f, coordZ);
			Vector3 rotation = new Vector3 (90.0f, 90.0f, 45.0f);

			Rigidbody coinClone = (Rigidbody)Instantiate (Coin, pos, transform.rotation);

		}
	}
}
