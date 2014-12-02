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

		GUI.backgroundColor = Color.black; 

		GUIStyle myStyle = new GUIStyle ();
		GUIStyle textStyle = new GUIStyle ();
		myStyle.fontSize = 30;
		myStyle.normal.textColor = Color.white;
		textStyle.alignment = (TextAnchor)TextAlignment.Left;
		textStyle.normal.textColor = Color.white;
		textStyle.fontSize = 14;

		/*
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
		*/ 

		GUI.Label (new Rect (Screen.width / 2 - 100, 50, 300, 20), "Turn Overview", myStyle);
		GUI.TextField (new Rect (Screen.width / 2 - 250, Screen.height / 4, 400, 100), "More on Attacking \n\t" + "If you are in Tokyo, you deal damage to all monsters outside of Tokyo.\n\t If you are outside of Tokyo, you deal damage to the monster in Tokyo. \n\n" +
			"3. Buying Cards \n\t" + 
		    "Optionally, after the dice are resolved, the player may purchase any of the three face up cards.\n\t" +
		    "Two energy points can also be spent to sweep(discard) all the shown cards and reveal 3 new cards.\n" +
		    "4. End turn \n\t" + "Once your turn is over, the next player can roll the dice.", textStyle);

		if (GUI.Button (new Rect (Screen.width / 2 - 150, 7 * Screen.height / 10, 150, 50), "Back")) {
			Application.LoadLevel(4);
		}
		if (GUI.Button (new Rect (Screen.width / 2, 7 * Screen.height / 10, 150, 50), "Next")) {
			Application.LoadLevel(6);
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, 4 * Screen.height / 5, 150, 50), "Main Menu")) {
			Application.LoadLevel(0);
		}

	}
}
