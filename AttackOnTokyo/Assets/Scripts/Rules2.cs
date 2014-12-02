using UnityEngine;
using System.Collections;

public class Rules2 : MonoBehaviour {

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
		
		GUI.Label (new Rect (Screen.width / 2 - 100, 50, 300, 20), "Turn Overview", myStyle);
		GUI.TextField (new Rect (Screen.width / 2 - 250, Screen.height / 4, 400, 100), "1. Rolling and Rerolling the dice \n\t Click the roll button to roll 6 dice.  Then choose which dice you like to keep. You may reroll any or all of the dice, twice.\n\t Dice kept on the first reroll can be kept again or rerolled on the second.\n" +
		//GUI.TextField (new Rect (Screen.width / 2 - 250, Screen.height / 4, 400, 100), "\t Roll 6 dice, choose however many to keep, then you may reroll any or all of the dice, twice.\n\t Dice kept on the first reroll can be kept again or rerolled on the second.\n" +
			"2. Resolving the Dice \n\t The symbols you get at the end of your rolling step are the actions for this turn: \n\t " + 
		    "• Rolling triples gives you victory points (e.g. 3 3's = 3 victory points, 3 2's = 2, etc.) \n\t\t Each additional roll of that number is worth an additional victory point.\n\t" +
		    "• Each energy result gives the monster an energy\n\t" +
		    "• Each attack results in a point of damage dealt to the monsters who are not in the same place as you \n\t" +
		    "• Each heart gives a monster 1 life point to a max of 10\n", textStyle);
		
		if (GUI.Button (new Rect (Screen.width / 2 - 150, 7 * Screen.height / 10, 150, 50), "Back")) {
			Application.LoadLevel(3);
		}
		if (GUI.Button (new Rect (Screen.width / 2, 7 * Screen.height / 10, 150, 50), "Next")) {
			Application.LoadLevel(5);
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, 4 * Screen.height / 5, 150, 50), "Main Menu")) {
			Application.LoadLevel(0);
		}
	}
}
