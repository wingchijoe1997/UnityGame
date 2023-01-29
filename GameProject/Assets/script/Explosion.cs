using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public float explosiontime = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, explosiontime);
	}
}
