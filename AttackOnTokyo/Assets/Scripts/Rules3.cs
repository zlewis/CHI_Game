using UnityEngine;
using System.Collections;

public class Rules3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		
		GUIStyle myStyle = new GUIStyle ();
		GUIStyle textStyle = new GUIStyle ();
		myStyle.fontSize = 30;
		myStyle.normal.textColor = Color.white;
		textStyle.alignment = (TextAnchor)TextAlignment.Left;
		textStyle.normal.textColor = Color.white;
		textStyle.fontSize = 12;
		
		GUI.Label (new Rect (Screen.width / 2 - 150, 50, 300, 20), "Becoming King of Tokyo", myStyle);
		GUI.TextField (new Rect (Screen.width / 2 - 350, Screen.height / 4, 400, 100), "At the start of the game no Monster is in Tokyo.\n" +
			"If Tokyo is unoccupied, the first Monster to obtain an attack token has to spend the attack token to take control of Tokyo, dealing no damage.\n" +
			"If you are attacked while in Tokyo, you have a choice to yield Tokyo to the Monster that attacked, while still taking the damage.\n" +
			"If you are eliminated while in Tokyo, the monster who eliminated you automatically takes control of Tokyo.\n" +
			"Advantages of being in Tokyo:\n\t" +
			"- When taking control of Tokyo you gain 1 victory point.\n\t" +
			"- When starting the turn in Tokyo you gain 2 victory points.\n" +
			"Disadvantages of being in Tokyo:\n\t" +
			"- While in Tokyo, the heart result on dice have no effect.", textStyle);
		
		if (GUI.Button (new Rect (Screen.width / 2 - 75, 7 * Screen.height / 10, 150, 50), "Back")) {
			Application.LoadLevel(4);
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, 4 * Screen.height / 5, 150, 50), "Main Menu")) {
			Application.LoadLevel(0);
		}
	}
}
