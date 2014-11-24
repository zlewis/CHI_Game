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
		
		GUIStyle myStyle = new GUIStyle ();
		GUIStyle textStyle = new GUIStyle ();
		myStyle.fontSize = 30;
		myStyle.normal.textColor = Color.white;
		textStyle.alignment = (TextAnchor)TextAlignment.Left;
		textStyle.normal.textColor = Color.white;
		
		GUI.Label (new Rect (Screen.width / 2 - 200, 50, 300, 20), "Turn Overview", myStyle);
		GUI.TextField (new Rect (Screen.width / 2 - 200, Screen.height / 3, 400, 100), "1. Rolling and Rerolling the dice \n\t Roll 6 dice, choose however many to keep, then you may reroll any or all of the dice, twice.\n\t Dice kept on the first reroll can be kept again or rerolled on the second.\n" +
			"2. Resolving the Dice \n\t The symbols you get at the end of your rolling step are the actions for this turn: \n\t - A triple 1,2,or 3 gives that many victory points (e.g. 3 3s = 3 victory points not 9) \n\t Each additional roll of that number is worth an additional victory point.\n\t" +
			"- Each energy result gives the monster an energy\n\t" +
			"- Each attack results in a point of damage dealt to the monsters who are not in the same place as you.\n\t If you are in tokyo, you deal damage to all monsters outside of tokyo.\n\t If you are outside of Tokyo, you deal damage to the monster in Tokyo. \n\t" +
			"- Each heart gives a monster 1 life point to a max of 10.", textStyle);
		
		if (GUI.Button (new Rect (Screen.width / 2 - 75, 3 * Screen.height / 5, 150, 50), "Next")) {
			print ('1');
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, 7 * Screen.height / 10, 150, 50), "Main Menu")) {
			Application.LoadLevel(0);
		}
	}
}
