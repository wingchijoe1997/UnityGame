using UnityEngine;
using System.Collections;

public class boss2 : MonoBehaviour {
	public int boss2hp = 3;
	private attackTrigger atk;
	public GameObject Explosion;
	public AudioClip dieSound;
	private coin COIN;
	private NextLevel2 nextLevel2;
	// Use this for initialization
	void Start () {
		atk = GameObject.FindGameObjectWithTag ("AttackTrigger").GetComponent<attackTrigger> ();
		COIN = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<coin>();
		nextLevel2 = GameObject.Find("BOSS2").GetComponent<NextLevel2>();
		
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("AttackTrigger")) {
			boss2hp -=1;
			if(boss2hp<=0 &&COIN.count >= 1000){
				nextLevel2.next();
				gameObject.SetActive(false);
			}

		}
	}
	// Update is called once per frame
	
	void Update () {
		/*if(boss2hp<=0 &&COIN.count >= 1000){			
			Destroy(gameObject);
			Instantiate (Explosion, transform.position, transform.rotation);
			//if(COIN.count >= 1000){
			Application.LoadLevel("win");
			//
		}*/
	}
	/*public void next(){
		Debug.Log ("routine2");
		Instantiate (Explosion, transform.position, transform.rotation);
		audio.PlayOneShot(dieSound);
		StartCoroutine(Wait(5f));
	}
	IEnumerator Wait(float waittime) {
		
		
		yield return new WaitForSeconds (waittime);
		Debug.Log ("routine");
		Application.LoadLevel ("win");
	}*/
}