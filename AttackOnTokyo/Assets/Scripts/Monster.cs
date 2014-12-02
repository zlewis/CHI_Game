using UnityEngine;
using System.Collections;

public class Monster : MonsterScript {

	private int xPosition = 100; 
	private int yPosition = 50; 
	public int number; 
	public Texture picture; 
	/*
	void Start(){
		number = number - 1; 
	}
	*/
	void OnGUI(){
		GUI.Label (new Rect (Screen.width - xPosition, (yPosition * (number - 1)) + 50 * (number - 1) + 30, 100, 100), "Health: " + "\t" + health);
		GUI.Label (new Rect (Screen.width - xPosition, (yPosition * (number - 1)) + 50 * (number - 1) + 45, 100, 100), "Energy: " + energy); 
		GUI.Label (new Rect (Screen.width - xPosition, (yPosition * (number - 1)) + 50 * (number - 1) + 60, 100, 100), "Points: " + "\t" + victoryPoints); 
		GUI.Box (new Rect (Screen.width - 204, (yPosition * (number - 1)) + 50 * (number - 1), 100, 100), picture);
	}
}

		          