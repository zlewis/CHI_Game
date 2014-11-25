using UnityEngine;
using System.Collections;

public class Rules1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		
		GUIStyle myStyle = new GUIStyle ();
		GUIStyle textStyle = new GUIStyle ();
		myStyle.fontSize = 50;
		myStyle.normal.textColor = Color.white;
		textStyle.alignment = (TextAnchor)TextAlignment.Center;
		textStyle.fontSize = 20;
		textStyle.normal.textColor = Color.white;

		GUI.Label (new Rect (Screen.width / 2 - 200, 100, 300, 20), "Goal of the Game", myStyle);
		GUI.TextField (new Rect (Screen.width / 2 - 200, Screen.height / 3, 400, 100), "The goal of the game is to become King of Tokyo. \nThe game is over when a Monster earns 20 Victor Points \nor if it is the last Monster standing.", textStyle);

		if (GUI.Button (new Rect (Screen.width / 2 - 75, 3 * Screen.height / 5, 150, 50), "Next")) {
			Application.LoadLevel(4);
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, 7 * Screen.height / 10, 150, 50), "Main Menu")) {
			Application.LoadLevel(0);
		}
	}

}