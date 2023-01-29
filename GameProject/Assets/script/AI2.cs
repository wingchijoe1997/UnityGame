using UnityEngine;
using System.Collections;

public class AI2 : MonoBehaviour {
	public float speedAbs =3f;
	private float speed = 3f;
	public Vector3 location;
	public int stop=1;
	public GameObject player = null;
	public GameObject AI = null;
	private move2 PLAYER;
	//private Animator anim;
	public float distance = 20f;
	
	// Use this for initialization
	
	
	void Start () {
		//anim = gameObject.GetComponent<Animator>();
		
		PLAYER = GameObject.FindGameObjectWithTag ("Player").GetComponent<move2> ();
		location = transform.position;
		StartCoroutine (Wait (5f));
		
	}
	
	void Update () {

		
		if ( speed > 0.1f) {
			transform.localScale = new Vector3(-1,1,1);
		}
		if (speed < 0.1f) {
			transform.localScale = new Vector3(1,1,1);
		}
		transform.Translate (speed * Time.deltaTime*stop, 0, 0);
		
		
		
	}
	
	IEnumerator Wait(float waittime) {
		float distancePNE = transform.position.x - player.transform.position.x; //-ve:player on right, +ve:player on left
		
		
		if (Mathf.Abs(distancePNE) < distance) {
			Debug.Log ("Hi");
			if (distancePNE > 0)
				speed = -1*speedAbs;
			else if (distancePNE < 0)
				speed = 1*speedAbs;
			
		} 
		else {
			
			yield return new WaitForSeconds (waittime);
			
			speed *= -1;
			stop = 0;
			StartCoroutine (Wait (5f));
			//yield return new WaitForSeconds (5.0f);
			stop = 1;
			
			
			
		}
		
		
		
		
	}
	/*void findplayer() {
		Debug.Log ("Hi");
		float distance1 = 20f;
		if(AI.transform.position.x - player.transform.position.x < 20) {
			AI.transform.TransformDirection(player.transform.position.x*speed*Time.deltaTime,0,0);
		}
		
		
	}*/
	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			PLAYER.Damage(1);
			StartCoroutine(PLAYER.Knockback(0.02f,50,player.transform.position));
		}
	}
	
	
}