using UnityEngine;
using System.Collections;

public class coin: MonoBehaviour {
	public int count = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		GUI.Label(new Rect(20,40, 200, 30), "Your points:"+ count);
	}
}
