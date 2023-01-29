using UnityEngine;
using System.Collections;

public class checkground : MonoBehaviour {


	private float Y;
	public Vector2 playerPosition;
	// Use this for initialization
	void Start () {
	
	}

	
	// Update is called once per frame
	void Update () {
	//	if (ground) {
	//		Y = Input.GetAxis("Vertical") *jump;
	//	}
	//	else {
	//		playerPosition=transform.position ;
	//	}
	}

	void OnCollisionEnter2D(Collision2D other) {

		GetComponentInParent<move2> ().setGround (true);

	}
	
	void OnCollisionStay2D(Collision2D other) {
		GetComponentInParent<move2> ().setGround (true);

	}
	
	void OnCollisionExit2D(Collision2D other) {
		GetComponentInParent<move2> ().setGround (false);
	}
}
