using UnityEngine;
using System.Collections;

public class Monster : MonsterScript {

	public int xPosition; 
	public int yPosition; 

	void OnGUI(){
		GUI.Label (new Rect (xPosition, yPosition, 100, 100), "Health: " + "\t" + health);
		GUI.Label (new Rect (xPosition, yPosition + 15, 100, 100), "Energy: " + energy); 
		GUI.Label (new Rect (xPosition, yPosition + 30, 100, 100), "Points: " + "\t" + victoryPoints); 
	}
}
