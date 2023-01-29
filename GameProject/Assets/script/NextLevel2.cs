using UnityEngine;
using System.Collections;

public class NextLevel2 : MonoBehaviour {
	public GameObject Explosion;
	public AudioClip dieSound;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void next(){
		Instantiate (Explosion, transform.position, transform.rotation);
		audio.PlayOneShot(dieSound);
		StartCoroutine(Wait(5f));
	}
	
	IEnumerator Wait(float waittime) {
		
		
		yield return new WaitForSeconds (waittime);
		Debug.Log ("routine");
		Application.LoadLevel ("win");
	}
}