using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
	
		GUI.Label(new Rect(Screen.width/2-50,100, 100, 20), "Main Menu");

		if (GUI.Button(new Rect(Screen.width/2-(75/2),Screen.height/2-25, 75, 50), "button 1"))
		{
            print("1");
		}
	}
}
