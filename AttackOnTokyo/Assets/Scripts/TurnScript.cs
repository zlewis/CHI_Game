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
	public bool rollDice=false;
	int rollNum=0;
	bool d1Lock=false;
	bool d2Lock=false;
	bool d3Lock=false;
	bool d4Lock=false;
	bool d5Lock=false;
	bool d6Lock=false;
	ArrayList diceRolls = new ArrayList();

	// Use this for initialization
	void Start () {

		monster1 = GameObject.Find ("monster1");
		monster2 = GameObject.Find ("monster2");
		monster3 = GameObject.Find ("monster3");
		monster4 = GameObject.Find ("monster4");
		monster5 = GameObject.Find ("monster5");

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
//		if(rollDice==true && rollNum<3)
//		{
//			diceRolls.Clear();
//			if(d1Lock==false)
//			{
//				diceRolls.Add(randNum());
//			}
//			if(d2Lock==false)
//			{
//				diceRolls.Add(randNum());
//			}
//			if(d3Lock==false)
//			{
//				diceRolls.Add(randNum());
//			}
//			if(d4Lock==false)
//			{
//				diceRolls.Add(randNum());
//			}
//			if(d5Lock==false)
//			{
//				diceRolls.Add(randNum());
//			}
//			if(d6Lock==false)
//			{
//				diceRolls.Add(randNum());
//			}
//
//			rollDice=false;
//			rollNum++;
//		}

		// Use Dice
		// End Turn

		if(endTurn)
		{
			ChangeChar();
		}
	}

	int randNum() {
		int dice;
		dice = (int)Random.Range (1, 7);
		return dice;
	}

	public void setRollDice(bool b) {
		rollDice = b;
	}

	public ArrayList getDiceRolls() {
		return diceRolls;
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
