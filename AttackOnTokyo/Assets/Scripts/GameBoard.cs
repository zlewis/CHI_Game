using UnityEngine;
using System.Collections;

public class GameBoard : MonoBehaviour {

	public TurnScript scriptReference;

	Texture2D die1;
	Texture2D die2;
	Texture2D die3;
	Texture2D die4;
	Texture2D die5;
	Texture2D die6;

	Texture2D box1;
	Texture2D box2;
	Texture2D box3;
	Texture2D box4;
	Texture2D box5;
	Texture2D box6;

	Texture2D bar;

	int rollCount=0;

	bool endRolling=false;

	ArrayList diceRolls = new ArrayList();
	ArrayList diceChosen = new ArrayList();
	ArrayList diceEnd = new ArrayList();

	public bool endTurn=false;

	public GUISkin Button_Skin;

	public bool toggle1=false;
	public bool toggle2=false;
	public bool toggle3=false;
	public bool toggle4=false;
	public bool toggle5=false;
	public bool toggle6=false;

	public bool showDice=false;

	int store1;
	int store2;
	int store3;
	int store4;
	int store5;
	int store6;

	// Use this for initialization
	void Start () {
		die1 = (Texture2D)Resources.Load("dice/die1");
		die2 = (Texture2D)Resources.Load("dice/die2");
		die3 = (Texture2D)Resources.Load("dice/die3");
		die4 = (Texture2D)Resources.Load("dice/die4");
		die5 = (Texture2D)Resources.Load("dice/die5");
		die6 = (Texture2D)Resources.Load("dice/die6");

		bar = (Texture2D)Resources.Load("dice/Bar2");

		diceChosen.Add (0);
		diceChosen.Add (0);
		diceChosen.Add (0);
		diceChosen.Add (0);
		diceChosen.Add (0);
		diceChosen.Add (0);

		diceEnd.Add (0);
		diceEnd.Add (0);
		diceEnd.Add (0);
		diceEnd.Add (0);
		diceEnd.Add (0);
		diceEnd.Add (0);
	}
	
	// Update is called once per frame
	void Update () {
		if(endRolling)
		{
			setDiceEnd();
			scriptReference.setDiceRolled(diceEnd);
			endRolling=false;
		}
	}

    private void OnGUI()
    {
		GUI.skin = Button_Skin;

//		if(endTurn==false)
//		{
//			showDice=true;
//		}

		// Main Menu Button
        if (GUI.Button(new Rect(0, 0, 150, 50), "Main Menu"))
        {
            Application.LoadLevel(0);
        }

		// End Turn Button
//		if(GUI.Button(new Rect(0,200,100,100), "End Turn"))
//		{
//			endTurn=true;
//		}

//		if(endTurn)
//		{
//			scriptReference.endTurn=true;
//		}

		// Roll Button
		if (GUI.Button(new Rect(0,Screen.height-50,50,50), "Roll"))
		{
			if(rollCount<3)
			{
				showDice=true;

				diceRolls.Add(randNum());
				diceRolls.Add(randNum());
				diceRolls.Add(randNum());
				diceRolls.Add(randNum());
				diceRolls.Add(randNum());
				diceRolls.Add(randNum());

				rollCount++;

				setBoxes ();
			}
		}

		// Rolls left label
		GUI.Label (new Rect (50, Screen.height - 70, 100, 50), 3 - rollCount + " Rolls Left");

		// Background for Dice
		GUI.Box (new Rect (50, Screen.height - 50, 350, 100), bar,"button1");

		// Dice Buttons
		if(showDice==true)
		{
			toggle1 = GUI.Toggle (new Rect (50, Screen.height - 50, 50, 50), toggle1, box1);
			toggle2 = GUI.Toggle (new Rect (100, Screen.height - 50, 50, 50), toggle2, box2);
			toggle3 = GUI.Toggle (new Rect (150, Screen.height - 50, 50, 50), toggle3, box3);
			toggle4 = GUI.Toggle (new Rect (200, Screen.height - 50, 50, 50), toggle4, box4);
			toggle5 = GUI.Toggle (new Rect (250, Screen.height - 50, 50, 50), toggle5, box5);
			toggle6 = GUI.Toggle (new Rect (300, Screen.height - 50, 50, 50), toggle6, box6);
		}

		setChosen ();

		if(rollCount>=3)
		{
			endRolling=true;
			rollCount=0;
		}

		diceRolls.Clear();
    }


	// Helper Functions ---------------------------------------------------------------------


	int randNum() {
		int dice;
		dice = (int)Random.Range (1, 7);
		return dice;
	}

	void setDiceEnd(){
		if ((int)diceChosen[0] == 0) 
		{
			diceEnd[0]=store1;
		}
		else
		{
			diceEnd[0]=diceChosen[0];
		}
		if ((int)diceChosen[1] == 0) 
		{
			diceEnd[1]=store2;
		}
		else
		{
			diceEnd[1]=diceChosen[1];
		}
		if ((int)diceChosen[2] == 0)
		{
			diceEnd[2]=store3;
		}
		else
		{
			diceEnd[2]=diceChosen[2];
		}
		if ((int)diceChosen[3] == 0) 
		{
			diceEnd[3]=store4;
		}
		else
		{
			diceEnd[3]=diceChosen[3];
		}
		if ((int)diceChosen[4] == 0) 
		{
			diceEnd[4]=store5;
		}
		else
		{
			diceEnd[4]=diceChosen[4];
		}
		if ((int)diceChosen[5] == 0) 
		{
			diceEnd[5]=store6;
		}
		else
		{
			diceEnd[5]=diceChosen[5];
		}
	}

	void setChosen(){
		if(toggle1 && (int)diceChosen[0]==0)
		{
			diceChosen[0]=store1;
		}
		else if(toggle1==false)
		{
			diceChosen[0]=0;
		}
		if(toggle2 && (int)diceChosen[1]==0)
		{
			diceChosen[1]=store2;
		}
		else if(toggle2==false)
		{
			diceChosen[1]=0;
		}
		if(toggle3 && (int)diceChosen[2]==0)
		{
			diceChosen[2]=store3;
		}
		else if(toggle3==false)
		{
			diceChosen[2]=0;
		}
		if(toggle4 && (int)diceChosen[3]==0)
		{
			diceChosen[3]=store4;
		}
		else if(toggle4==false)
		{
			diceChosen[3]=0;
		}
		if(toggle5 && (int)diceChosen[4]==0)
		{
			diceChosen[4]=store5;
		}
		else if(toggle5==false)
		{
			diceChosen[4]=0;
		}
		if(toggle6 && (int)diceChosen[5]==0)
		{
			diceChosen[5]=store6;
		}
		else if(toggle6==false)
		{
			diceChosen[5]=0;
		}
	}

	void setBoxes(){
		if(toggle1==false){store1 = (int)diceRolls [0];}
		if(toggle2==false){store2 = (int)diceRolls [1];}
		if(toggle3==false){store3 = (int)diceRolls [2];}
		if(toggle4==false){store4 = (int)diceRolls [3];}
		if(toggle5==false){store5 = (int)diceRolls [4];}
		if(toggle6==false){store6 = (int)diceRolls [5];}

		for(int i=0;i<6;i++)
		{
			if((int)diceRolls[i]==1)
			{
				if(i==0 && toggle1==false){box1=die1;}
				if(i==1 && toggle2==false){box2=die1;}
				if(i==2 && toggle3==false){box3=die1;}
				if(i==3 && toggle4==false){box4=die1;}
				if(i==4 && toggle5==false){box5=die1;}
				if(i==5 && toggle6==false){box6=die1;}
			}
			if((int)diceRolls[i]==2)
			{
				if(i==0 && toggle1==false){box1=die2;}
				if(i==1 && toggle2==false){box2=die2;}
				if(i==2 && toggle3==false){box3=die2;}
				if(i==3 && toggle4==false){box4=die2;}
				if(i==4 && toggle5==false){box5=die2;}
				if(i==5 && toggle6==false){box6=die2;}
			}
			if((int)diceRolls[i]==3)
			{
				if(i==0 && toggle1==false){box1=die3;}
				if(i==1 && toggle2==false){box2=die3;}
				if(i==2 && toggle3==false){box3=die3;}
				if(i==3 && toggle4==false){box4=die3;}
				if(i==4 && toggle5==false){box5=die3;}
				if(i==5 && toggle6==false){box6=die3;}
			}
			if((int)diceRolls[i]==4)
			{
				if(i==0 && toggle1==false){box1=die4;}
				if(i==1 && toggle2==false){box2=die4;}
				if(i==2 && toggle3==false){box3=die4;}
				if(i==3 && toggle4==false){box4=die4;}
				if(i==4 && toggle5==false){box5=die4;}
				if(i==5 && toggle6==false){box6=die4;}
			}
			if((int)diceRolls[i]==5)
			{
				if(i==0 && toggle1==false){box1=die5;}
				if(i==1 && toggle2==false){box2=die5;}
				if(i==2 && toggle3==false){box3=die5;}
				if(i==3 && toggle4==false){box4=die5;}
				if(i==4 && toggle5==false){box5=die5;}
				if(i==5 && toggle6==false){box6=die5;}
			}
			if((int)diceRolls[i]==6)
			{
				if(i==0 && toggle1==false){box1=die6;}
				if(i==1 && toggle2==false){box2=die6;}
				if(i==2 && toggle3==false){box3=die6;}
				if(i==3 && toggle4==false){box4=die6;}
				if(i==4 && toggle5==false){box5=die6;}
				if(i==5 && toggle6==false){box6=die6;}
			}
		}
	}
}
