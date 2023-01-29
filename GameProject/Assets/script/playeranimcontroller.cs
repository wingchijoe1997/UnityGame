using UnityEngine;
using System.Collections;

public class playeranimcontroller : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
