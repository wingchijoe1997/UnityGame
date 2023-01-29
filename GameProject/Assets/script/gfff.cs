using UnityEngine;
using System.Collections;

public class gfff : MonoBehaviour {
	private int level1enemyhp=2;
	private int boss1hp=3;
	private int level2enemyhp=3;
	private int boss2hp=5;
	private float cd = 1;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		
		if (other.gameObject.tag == "enemy") {
			level1enemyhp -=1;
			if(level1enemyhp==0){

			Destroy (other.gameObject);

			}
		}
		if (other.gameObject.tag == "boss1") {
			boss1hp -=1;

			
			if(boss1hp==0){
			Destroy (other.gameObject);
			Application.LoadLevel ("level2");
			}
		}
		if (other.gameObject.tag == "boss2") {

			boss2hp -=1;
			if(boss2hp==0){
				Destroy (other.gameObject);
				Application.LoadLevel ("win");
			}
		}

	}

}