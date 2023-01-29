using UnityEngine;
using System.Collections;

public class boss1 : MonoBehaviour {
	public int boss1hp = 3;
	private attackTrigger atk;
	private NextLevel nextLevel;

	private coin COIN;
	// Use this for initialization
	void Start () {
		atk = GameObject.FindGameObjectWithTag ("AttackTrigger").GetComponent<attackTrigger> ();
		COIN = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<coin>();
		nextLevel = GameObject.Find("BOSS1").GetComponent<NextLevel>();
		
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("AttackTrigger")) {
			boss1hp -=1;
			if(boss1hp <= 0&& COIN.count >= 500){

				nextLevel.next();

				gameObject.SetActive(false);

			}
		}
	}
	// Update is called once per frame
	
	void Update () {

		}
	IEnumerator Wait(float waittime) {
		
		
		yield return new WaitForSeconds (waittime);
		Debug.Log ("routine");
		Application.LoadLevel ("level2");
	}





}