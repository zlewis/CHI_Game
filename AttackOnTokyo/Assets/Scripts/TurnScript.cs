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

	Texture2D turnBox;

	bool drawExitBool=false;
	bool change=true;

	// Use this for initialization
	void Start () {
		turnBox = (Texture2D)Resources.Load("dice/ButtonHighlight2");

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
			//scriptReference7.addPoints(vPointsEarned); 
			//scriptReference7.addEnergy(energyEarned);
			//scriptReference7.addHealth(healthEarned);
			if(scriptReference7.health>10)
			{
				scriptReference7.health=10;
			}

			// Do attacks
			if(attackEarned>0)
			{
				// Current monster not in tokyo
				if(scriptReference7.inCity==false)
				{
					if(scriptReference1.inCity==true)
					{
						scriptReference1.health-=attackEarned;
						drawExitQuestion();
					}
					else if(scriptReference2.inCity==true)
					{
						scriptReference2.health-=attackEarned;
						drawExitQuestion();
					}
					else if(scriptReference3.inCity==true)
					{
						scriptReference3.health-=attackEarned;
						drawExitQuestion();
					}
					else if(scriptReference4.inCity==true)
					{
						scriptReference4.health-=attackEarned;
						drawExitQuestion();
					}
					else if(scriptReference5.inCity==true)
					{
						scriptReference5.health-=attackEarned;
						drawExitQuestion();
					}
					else if(scriptReference6.inCity==true)
					{
						scriptReference6.health-=attackEarned;
						drawExitQuestion();
					}
					else
					{
						scriptReference7.inCity=true;
						ChangeChar();
					}

					diceRolledSet=false;
//					if(change)
//					{
//						ChangeChar();
//					}
					change=false;
				}

				// Current monster in tokyo
				else if(scriptReference7.inCity==true)
				{
					if(scriptReference7.name!=scriptReference1.name)
					{
						scriptReference1.health-=attackEarned;
					}
					if(scriptReference7.name!=scriptReference2.name)
					{
						scriptReference2.health-=attackEarned;
					}
					if(scriptReference7.name!=scriptReference3.name)
					{
						scriptReference3.health-=attackEarned;
					}
					if(scriptReference7.name!=scriptReference4.name)
					{
						scriptReference4.health-=attackEarned;
					}
					if(scriptReference7.name!=scriptReference5.name)
					{
						scriptReference5.health-=attackEarned;
					}
					if(scriptReference7.name!=scriptReference6.name)
					{
						scriptReference6.health-=attackEarned;
					}

					change=true;
					endTurn=true;
				}
			}

			else
			{
				change=true;
				endTurn=true;
			}
			//endTurn=true;
		}

		// Check for death and victory

		// End Turn

		if(endTurn)
		{
			scriptReference.resetToggle();
			diceRolledSet=false;
			if(change)
			{
				ChangeChar();
			}
			endTurn=false;
		}
	}

	void OnGUI() {
		drawTurnSquare ();

		if(drawExitBool==true)
		{
			GUI.Box (new Rect (0, 400, 200, 100), "Leave Tokyo?");
			if(GUI.Button(new Rect(25,450,50,50), "Yes"))
			{
				if(scriptReference1.inCity==true)
				{
					scriptReference1.inCity=false;
				}
				if(scriptReference2.inCity==true)
				{
					scriptReference2.inCity=false;
				}
				if(scriptReference3.inCity==true)
				{
					scriptReference3.inCity=false;
				}
				if(scriptReference4.inCity==true)
				{
					scriptReference4.inCity=false;
				}
				if(scriptReference5.inCity==true)
				{
					scriptReference5.inCity=false;
				}
				if(scriptReference6.inCity==true)
				{
					scriptReference6.inCity=false;
				}

				scriptReference7.inCity=true;

				change=true;
				endTurn=true;
				drawExitBool=false;
			}
			if(GUI.Button(new Rect(100,450,50,50), "No"))
			{
				change=true;
				endTurn=true;
				drawExitBool=false;
			}
		}

		moveMonster ();
	}


	// Hepler Functions ------------------------------------------------------------


	void moveMonster() {
		if(scriptReference1.inCity==true)
		{
			Vector3 temp;
			temp.x=-2f;
			temp.y=0;
			temp.z=-0.1f;
			scriptReference1.transform.position=temp;
		}
		else
		{
			Vector3 temp;
			temp=scriptReference1.basicPos;
			scriptReference1.transform.position=temp;
		}
		if(scriptReference2.inCity==true)
		{
			Vector3 temp;
			temp.x=-2f;
			temp.y=0;
			temp.z=-0.1f;
			scriptReference2.transform.position=temp;
		}
		else
		{
			Vector3 temp;
			temp=scriptReference2.basicPos;
			scriptReference2.transform.position=temp;
		}
		if(scriptReference3.inCity==true)
		{
			Vector3 temp;
			temp.x=-2f;
			temp.y=0;
			temp.z=-0.1f;
			scriptReference3.transform.position=temp;
		}
		else
		{
			Vector3 temp;
			temp=scriptReference3.basicPos;
			scriptReference3.transform.position=temp;
		}
		if(scriptReference4.inCity==true)
		{
			Vector3 temp;
			temp.x=-2f;
			temp.y=0;
			temp.z=-0.1f;
			scriptReference4.transform.position=temp;
		}
		else
		{
			Vector3 temp;
			temp=scriptReference4.basicPos;
			scriptReference4.transform.position=temp;
		}
		if(scriptReference5.inCity==true)
		{
			Vector3 temp;
			temp.x=-2f;
			temp.y=0;
			temp.z=-0.1f;
			scriptReference5.transform.position=temp;
		}
		else
		{
			Vector3 temp;
			temp=scriptReference5.basicPos;
			scriptReference5.transform.position=temp;
		}
		if(scriptReference6.inCity==true)
		{
			Vector3 temp;
			temp.x=-2f;
			temp.y=0;
			temp.z=-0.1f;
			scriptReference6.transform.position=temp;
		}
		else
		{
			Vector3 temp;
			temp=scriptReference6.basicPos;
			scriptReference6.transform.position=temp;
		}
	}

	void drawExitQuestion() {
		drawExitBool = true;
	}

	void drawTurnSquare() {
		if(activeInt==0)
		{
			GUI.Box(new Rect(Screen.width-210,0,110,110),turnBox,"button1");
		}
		else if(activeInt==1)
		{
			GUI.Box(new Rect(Screen.width-210,95,110,110),turnBox,"button1");
		}
		else if(activeInt==2)
		{
			GUI.Box(new Rect(Screen.width-210,195,110,110),turnBox,"button1");
		}
		else if(activeInt==3)
		{
			GUI.Box(new Rect(Screen.width-210,295,110,110),turnBox,"button1");
		}
		else if(activeInt==4)
		{
			GUI.Box(new Rect(Screen.width-210,395,110,110),turnBox,"button1");
		}
		else if(activeInt==5)
		{
			GUI.Box(new Rect(Screen.width-210,495,110,110),turnBox,"button1");
		}
	}

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
