using UnityEngine;
using System.Collections;

public class Playerattack : MonoBehaviour {
	private bool attacking= false;
	public Collider2D attackTrigger;
	private Animator anim;
	public AudioClip AttackSound;


	public float attackTimer=0;
	private float attackCd = 0.3f;

	// Use this for initialization
	//call attackTrigger
	void Awake () {
		anim = gameObject.GetComponent<Animator> ();
		attackTrigger.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("z") && !attacking) {
			attacking = true;
			audio.PlayOneShot(AttackSound);
			attackTimer = attackCd;

			attackTrigger.enabled = true;


		} 
		//防止一直攻擊
		if (attacking) {
			if (attackTimer > 0) {
				attackTimer -= Time.deltaTime;
			} else {
				attacking = false;
				attackTrigger.enabled = false;	
			}
		}
		anim.SetBool ("attack",attacking);
	}
}
