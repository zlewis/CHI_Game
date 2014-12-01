using UnityEngine;
using System.Collections;

public class TurnScript : MonoBehaviour {

	GameObject monster1;
	GameObject monster2;
	GameObject monster3;
	GameObject monster4;
	GameObject monster5;
	GameObject monster6;

	// TODO Get number of players
	int numPlayers=6;
	ArrayList CharList = new ArrayList();
	GameObject activeChar;
	int activeInt=0;
	bool endTurn=false;
	ArrayList diceRolled = new ArrayList();
	bool diceRolledSet=false;

	// Use this for initialization
	void Start () {

		monster1 = GameObject.Find ("CyberBunny");
		monster2 = GameObject.Find ("Kraken");
		monster3 = GameObject.Find ("TheKing");
		monster4 = GameObject.Find ("GigaZaur");
		monster5 = GameObject.Find ("Alienoid");
		monster6 = GameObject.Find ("MekaDragon");

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
			// In GameBoard.cs
		// Use Dice
			
		// End Turn

		if(endTurn)
		{
			ChangeChar();
		}
	}

	void OnGUI() {

	}


	// Hepler Functions ------------------------------------------------------------


	int randNum() {
		int dice;
		dice = (int)Random.Range (1, 7);
		return dice;
	}

	public void setDiceRolled(ArrayList b) {
		diceRolled = b;
		diceRolledSet = true;
		//print(diceRolled[0]+","+diceRolled[1]+","+diceRolled[2]+","+diceRolled[3]+","+diceRolled[4]+","+diceRolled[5]);
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
