using UnityEngine;
using System.Collections;

public class level1enemy : MonoBehaviour {
	public int level1enemyhp =2;
	public int speed = 1;
	private attackTrigger atk;
	public GameObject Explosion;
	public AudioClip dieSound;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		atk = GameObject.FindGameObjectWithTag ("AttackTrigger").GetComponent<attackTrigger> ();

	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("AttackTrigger")) {
			level1enemyhp -=1;
		}
	}
	// Update is called once per frame

	void Update () {

		if(level1enemyhp<=0){
			audio.PlayOneShot(dieSound);
			Destroy(gameObject);
			Instantiate(Explosion,transform.position,transform.rotation);
		}
	}
}
