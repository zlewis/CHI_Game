using UnityEngine;
using System.Collections;

public class Rules4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		GUI.backgroundColor = Color.black; 

		GUIStyle myStyle = new GUIStyle ();
		GUIStyle textStyle = new GUIStyle ();
		myStyle.fontSize = 30;
		myStyle.normal.textColor = Color.white;
		textStyle.alignment = (TextAnchor)TextAlignment.Left;
		textStyle.normal.textColor = Color.white;
		textStyle.fontSize = 14;

		GUI.Label (new Rect (Screen.width / 2 - 150, 50, 300, 20), "Becoming King of Tokyo", myStyle);
		GUI.TextField (new Rect (Screen.width / 2 - 350, Screen.height / 4, 400, 100), "At the start of the game no Monster is in Tokyo.\n" +
			"If Tokyo is unoccupied, the first Monster to obtain an attack token has to spend the attack token to take control of Tokyo, dealing no damage.\n" +
			"If you are attacked while in Tokyo, you can leave Tokyo and switch places with the Monster that attacked, while still taking the damage.\n" +
			"If you are eliminated while in Tokyo, the Monster who eliminated you automatically takes control of Tokyo.\n" +
			"Advantages of being in Tokyo:\n\t" +
		  	"• You gain 1 victory point for taking over Tokyo\n\t" +
		  	"• You gain 2 victory points for every turn in Tokyo\n" +
		   	"Disadvantages of being in Tokyo:\n\t" +
			"• The heart result on dice have no effect", textStyle);

		if (GUI.Button (new Rect (Screen.width / 2 - 75, 7 * Screen.height / 10, 150, 50), "Back")) {
			Application.LoadLevel(5);
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 75, 4 * Screen.height / 5, 150, 50), "Main Menu")) {
			Application.LoadLevel(0);
		}
	}
}
