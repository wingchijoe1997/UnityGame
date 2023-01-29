using UnityEngine;
using System.Collections;

public class hptext : MonoBehaviour {
	private int hp = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		GUI.Label(new Rect(20, 20, 200, 30), "Your live:"+hp);
	}

}
