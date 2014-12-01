using UnityEngine;
using System.Collections;

public class TurnScript : MonoBehaviour {

	public GameBoard scriptReference;
	public MonsterScript scriptReference1;
	public MonsterScript scriptReference2;
	public MonsterScript scriptReference3;
	public MonsterScript scriptReference4;
	public MonsterScript scriptReference5;
	public MonsterScript scriptReference6;
	public MonsterScript scriptReference7;

	string monster1;
	string monster2;
	string monster3;
	string monster4;
	string monster5;
	string monster6;

	// TODO Get number of players
	int numPlayers=6;
	ArrayList CharList = new ArrayList();
	string activeChar;
	int activeInt=0;
	public bool endTurn=false;
	ArrayList diceRolled = new ArrayList();
	bool diceRolledSet=false;
	int vPointsEarned=0;
	int energyEarned=0;
	int attackEarned=0;
	int healthEarned=0;

	// Use this for initialization
	void Start () {

		monster1 = "CyberBunny";
		monster2 = "Kraken";
		monster3 = "TheKing";
		monster4 = "GigaZaur";
		monster5 = "Alienoid";
		monster6 = "MekaDragon";
		scriptReference7 = scriptReference1;

		CharList.Add (monster1);
		CharList.Add (monster2);
		if(numPlayers>=3){CharList.Add (monster3);}
		if(numPlayers>=4){CharList.Add (monster4);}
		if(numPlayers>=5){CharList.Add (monster5);}
		if(numPlayers>=6){CharList.Add (monster6);}

		activeChar = (string)CharList[activeInt];
	}
	
	// Update is called once per frame
	void Update () {

		// Roll Dice
			// In GameBoard.cs
		// Use Dice
		if(diceRolledSet)
		{
			vPointsEarned = checkNum(1);
			vPointsEarned += checkNum(2);
			vPointsEarned += checkNum(3);
			energyEarned = checkSym(4);
			attackEarned = checkSym(5);
			healthEarned = checkSym(6);
		
			scriptReference7.victoryPoints += vPointsEarned;
			scriptReference7.energy += energyEarned;
			scriptReference7.health += healthEarned;
			if(scriptReference7.health>10)
			{
				//scriptReference7.health=10;
			}

			//diceRolledSet=false;
			endTurn=true;
		}

		// Have to make a variable to see who is in the city
		// Check for death and victory

		// End Turn

		if(endTurn)
		{
			scriptReference.showDice=false;
			diceRolledSet=false;
			ChangeChar();
			endTurn=false;
			//scriptReference.endTurn=false;
		}
	}

	void OnGUI() {

	}


	// Hepler Functions ------------------------------------------------------------
	

	void setActiveScript() {
		if(activeChar==monster1)
		{
			scriptReference7=scriptReference1;
		}
		else if(activeChar==monster2)
		{
			scriptReference7=scriptReference2;
		}
		else if(activeChar==monster3)
		{
			scriptReference7=scriptReference3;
		}
		else if(activeChar==monster4)
		{
			scriptReference7=scriptReference4;
		}
		else if(activeChar==monster5)
		{
			scriptReference7=scriptReference5;
		}
		else if(activeChar==monster6)
		{
			scriptReference7=scriptReference6;
		}
	}

	int checkNum(int a) {
		int numCount = 0;
		int pointsEarned = 0;

		for(int i=0;i<6;i++)
		{
			if((int)diceRolled[i]==a)
			{
				numCount++;
			}
		}

		if(numCount>=3)
		{
			pointsEarned=a;
			if(numCount==4)
			{
				pointsEarned+=1;
			}
			if(numCount==5)
			{
				pointsEarned+=2;
			}
			if(numCount==6)
			{
				pointsEarned+=3;
			}
		}

		return pointsEarned;
	}

	int checkSym(int a) {
		int symCount = 0;

		for(int i=0;i<6;i++)
		{
			if((int)diceRolled[i]==a)
			{
				symCount++;
			}
		}

		return symCount;
	}

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
		if(activeInt>=6)
		{
			activeInt=0;
			activeChar=(string)CharList[activeInt];
			setActiveScript();
		}
		else
		{
			activeChar=(string)CharList[activeInt];
			setActiveScript();
		}
	}
}
