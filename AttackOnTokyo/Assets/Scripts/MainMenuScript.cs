using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	//public GameSettings scriptReference;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {

        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 50;
        myStyle.normal.textColor = Color.white;

        GUI.Label(new Rect(Screen.width / 2 - 150, 100, 300, 20), "King of Tokyo", myStyle);

		if (GUI.Button(new Rect(Screen.width/2-75,2*Screen.height/5, 150, 50), "Start Game"))
		{
            Application.LoadLevel(1);
		}
        if (GUI.Button(new Rect(Screen.width/2-75, Screen.height/2, 150, 50), "Game Settings"))
        {
            Application.LoadLevel(2);
        }
        if (GUI.Button(new Rect(Screen.width/2-75, 3*Screen.height/5, 150, 50), "How to play?"))
        {
			Application.LoadLevel(3);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 75, 7 * Screen.height / 10, 150, 50), "Quit"))
        {
            Application.Quit();
        }
	}
}
