using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

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
		GUI.Label(new Rect(Screen.width/2-100, Screen.height/2-100 , 300, 200), "小男孩冒險記 - 保衛家園",myStyle);
		GUI.Label(new Rect(Screen.width/2-70, Screen.height/2-60 , 300, 200), "玩法:\n左右方向鍵=控制角色左右移動\n空白鍵=跳\n如不收集所有金幣,boss不會死!");
		if(GUI.Button(new Rect(Screen.width *Button1Pos.x -(Button1Size.x/2), Screen.height *Button1Pos.y -(Button1Size.y/2), Button1Size.x, Button1Size.y), "Start"))
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
