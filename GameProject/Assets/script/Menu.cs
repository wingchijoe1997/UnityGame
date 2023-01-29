using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	public GameObject StartUI;

	// Use this for initialization
	void Start () {
		StartUI.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {

		}

	public void start(){
		Application.LoadLevel("Main");
	}
	public void Quit(){
		Application.Quit ();
	}
}
