using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HUD : MonoBehaviour {
	public Sprite[] HeartSprites;
	public Image HeartUI;
	private move2 player;

	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<move2>();

	}
	void Update(){
		HeartUI.sprite = HeartSprites[player.CurrentHealth];
	}

}


