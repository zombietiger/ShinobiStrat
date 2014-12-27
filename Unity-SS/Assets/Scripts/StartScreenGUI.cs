using UnityEngine;
using System.Collections;

public class StartScreenGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		//setup position variables
		float offsetW = Screen.width / 2 - Screen.width / 4;
		float offsetH = Screen.height / 2 - Screen.height / 4;
		float centerW = Screen.width / 2;
		float centerH = Screen.height / 2;
		//start group
		GUI.BeginGroup (new Rect(0,0,1024,800));
		//Draw background
		GUI.DrawTexture (new Rect(0,0,1024,800), Resources.Load ("bgOrange") as Texture);
		//create font
		Font gong = Resources.Load ("Gong") as Font;
		//make title style
		GUIStyle brushedThemeTextTitle = new GUIStyle ();
		brushedThemeTextTitle.font = gong;
		brushedThemeTextTitle.fontSize = 80;
		brushedThemeTextTitle.alignment = TextAnchor.MiddleCenter;
		//make regular style
		GUI.backgroundColor = Color.clear;
		GUIStyle brushedThemeText = new GUIStyle (GUI.skin.button);
		brushedThemeText.font = gong;
		brushedThemeText.fontSize = 25;
		brushedThemeText.alignment = TextAnchor.MiddleCenter;
		brushedThemeText.onHover.textColor = Color.white;
		brushedThemeText.hover.textColor = Color.white;
		brushedThemeText.onFocused.textColor = Color.white;
		brushedThemeText.focused.textColor = Color.white;
		brushedThemeText.onActive.textColor = Color.white;
		brushedThemeText.active.textColor = Color.white;
		brushedThemeText.normal.textColor = Color.black;
		//draw title
		GUI.Label (new Rect (offsetW, offsetH - 100, centerW, 200), "Kage", brushedThemeTextTitle);
		//draw buttons
		if (GUI.Button(new Rect(offsetW,offsetH+150,centerW,100),"Continue",brushedThemeText)) {

		}
		if (GUI.Button(new Rect(offsetW,offsetH+250,centerW,100),"New Game",brushedThemeText)) {
			gameObject.GetComponent<ScreenManager>().drawScreen( gameObject.GetComponent<MasterController>().buildCharacterScreenInit, gameObject.GetComponent<MasterController>().buildCharacterScreenClean );
		}
		if (GUI.Button(new Rect(offsetW,offsetH+350,centerW,100),"Options",brushedThemeText)) {
			
		}
		GUI.EndGroup ();

	}
}
