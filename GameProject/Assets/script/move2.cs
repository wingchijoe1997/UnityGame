using UnityEngine;
using System.Collections;

public class move2 : MonoBehaviour {
	public float speed = 50f;
	public float jump = 200f;
	private bool grounded = false;
	private coin COIN;
	public int CurrentHealth;
	public int MaxHealth = 5;
	private Rigidbody2D rb2d;
	public float maxSpeed = 3;
	public AudioClip walkSound;
	public AudioClip collectSound;


	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		CurrentHealth = MaxHealth;
		COIN = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<coin>();
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
	}
	void Update () {

		anim.SetBool ("grounded", grounded);
		anim.SetFloat ("speed",Mathf.Abs(Input.GetAxis("Horizontal")));

		if (grounded) {
			if (Input.GetButtonDown ("Jump")) {
				rb2d.AddForce (Vector2.up * jump);
			}
		}
		if (Input.GetAxis ("Horizontal") < -0.1f) {
			transform.localScale = new Vector3(-1,1,1);
			audio.PlayOneShot(walkSound);


		}
		if (Input.GetAxis ("Horizontal") > 0.1f) {
			transform.localScale = new Vector3(1,1,1);
			audio.PlayOneShot(walkSound);
		}

		if (CurrentHealth > MaxHealth) {
			CurrentHealth = MaxHealth;
		}
		if (CurrentHealth <= 0) {
			Die ();
		}

	}
	void FixedUpdate () {

		float h = Input.GetAxis ("Horizontal");
		rb2d.AddForce ((Vector2.right * speed) * h);
		if (rb2d.velocity.x > maxSpeed) {
			rb2d.velocity = new Vector2(maxSpeed,rb2d.velocity.y);
		
		}
		if (rb2d.velocity.x < - maxSpeed) {
			rb2d.velocity = new Vector2(-maxSpeed,rb2d.velocity.y);
		}




	}
	public void Damage(int dmg){
		CurrentHealth -= dmg;
	
	}
	void Die(){
		Application.LoadLevel(Application.loadedLevel);
	}

	public void setGround(bool value){
		this.grounded = value;
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("coin")){
			audio.PlayOneShot(collectSound);
			Destroy (col.gameObject);
			COIN.count+=100;
		}

	}
	public IEnumerator Knockback(float knockDur,float knockbackPwr,Vector3 knockbackDir){
		float timer = 0;
		while(knockDur>timer){{
				timer+=Time.deltaTime;
				rb2d.AddForce(new Vector3(knockbackDir.x* 150,knockbackDir.y*knockbackPwr,transform.position.x));
			}
			yield return 0;
		}
		
	}



}
