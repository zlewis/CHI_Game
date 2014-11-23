using UnityEngine;
using System.Collections;

public class TurnScript : MonoBehaviour {

	GameObject monster1 = GameObject.Find ("monster1");
	GameObject monster2 = GameObject.Find ("monster2");
	GameObject monster3 = GameObject.Find ("monster3");
	GameObject monster4 = GameObject.Find ("monster4");
	GameObject monster5 = GameObject.Find ("monster5");
	GameObject monster6 = GameObject.Find ("monster6");

	// TODO Get number of players
	int numPlayers;

	// Create a list of the active players
	ArrayList CharList;

	GameObject activeChar;
	int activeInt=0;

	bool endTurn=false;

	// Use this for initialization
	void Start () {

		CharList.Add (monster1);
		CharList.Add (monster2);
		if(numPlayers>=3){CharList.Add (monster3);}
		if(numPlayers>=4){CharList.Add (monster4);}
		if(numPlayers>=5){CharList.Add (monster5);}
		if(numPlayers>=6){CharList.Add (monster6);}

		activeChar = (GameObject)CharList[activeInt];
	}
	
	// Update is called once per frame
	void Update () {
		
		// Roll Dice
		// Use Dice
		// End Turn

		if(endTurn)
		{
			ChangeChar();
		}
	}

	void ChangeChar() {
		activeInt++;
		if(activeInt>=CharList.Capacity)
		{
			activeInt=0;
			activeChar=(GameObject)CharList[activeInt];
		}
		else
		{
			activeChar=(GameObject)CharList[activeInt];
		}
	}
}
