using UnityEngine;
using System.Collections;

public class fall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			gameObject.transform.Translate(0,-1,0);
		}
	}
}
