using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {

	public Texture background;

	public Vector2 Button1Pos;
	public Vector2 Button2Pos;
	public Vector2 Button1Size;
	public Vector2 Button2Size;
	private bool click = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {

		GUIStyle myStyle = new GUIStyle (GUI.skin.GetStyle("label"));
		myStyle.fontSize = 20;
		GUI.contentColor = Color.black;
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background);
		GUI.Label(new Rect(Screen.width/2-130, Screen.height/2-50 , 300, 200), "你成功擊敗所有BOSS!成功保衛自己的家園!恭喜!",myStyle);
		if(GUI.Button(new Rect(Screen.width *Button1Pos.x -(Button1Size.x/2), Screen.height *Button1Pos.y -(Button1Size.y/2), Button1Size.x, Button1Size.y), "Play again"))
		{
			click = true;
			Application.LoadLevel("Main");
		}
		if(GUI.Button(new Rect(Screen.width *Button2Pos.x -(Button2Size.x/2), Screen.height *Button2Pos.y -(Button2Size.y/2), Button2Size.x, Button2Size.y), "Exit"))
		{
			click = true;
			Application.Quit();
		}
	}
}
