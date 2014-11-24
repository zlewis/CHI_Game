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

	ArrayList diceRolls = new ArrayList();

	// Use this for initialization
	void Start () {
		die1 = (Texture2D)Resources.Load("dice/die1");
		die2 = (Texture2D)Resources.Load("dice/die2");
		die3 = (Texture2D)Resources.Load("dice/die3");
		die4 = (Texture2D)Resources.Load("dice/die4");
		die5 = (Texture2D)Resources.Load("dice/die5");
		die6 = (Texture2D)Resources.Load("dice/die6");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 150, 50), "Main Menu"))
        {
            Application.LoadLevel(0);
        }
		if (GUI.Button(new Rect(0,Screen.height-50,50,50), "Roll"))
		{
			diceRolls.Add(randNum());
			diceRolls.Add(randNum());
			diceRolls.Add(randNum());
			diceRolls.Add(randNum());
			diceRolls.Add(randNum());
			diceRolls.Add(randNum());

			//scriptReference.Update ();

			//diceRolls = scriptReference.getDiceRolls ();

			setBoxes ();
			diceRolls.Clear();
		}
		GUI.Box (new Rect (50, Screen.height - 50, 50, 50), box1);
		GUI.Box (new Rect (100, Screen.height - 50, 50, 50), box2);
		GUI.Box (new Rect (150, Screen.height - 50, 50, 50), box3);
		GUI.Box (new Rect (200, Screen.height - 50, 50, 50), box4);
		GUI.Box (new Rect (250, Screen.height - 50, 50, 50), box5);
		GUI.Box (new Rect (300, Screen.height - 50, 50, 50), box6);
    }

	int randNum() {
		int dice;
		dice = (int)Random.Range (1, 7);
		return dice;
	}

	void setBoxes(){
		for(int i=0;i<6;i++)
		{
			if((int)diceRolls[i]==1)
			{
				if(i==0){box1=die1;}
				if(i==1){box2=die1;}
				if(i==2){box3=die1;}
				if(i==3){box4=die1;}
				if(i==4){box5=die1;}
				if(i==5){box6=die1;}
			}
			if((int)diceRolls[i]==2)
			{
				if(i==0){box1=die2;}
				if(i==1){box2=die2;}
				if(i==2){box3=die2;}
				if(i==3){box4=die2;}
				if(i==4){box5=die2;}
				if(i==5){box6=die2;}
			}
			if((int)diceRolls[i]==3)
			{
				if(i==0){box1=die3;}
				if(i==1){box2=die3;}
				if(i==2){box3=die3;}
				if(i==3){box4=die3;}
				if(i==4){box5=die3;}
				if(i==5){box6=die3;}
			}
			if((int)diceRolls[i]==4)
			{
				if(i==0){box1=die4;}
				if(i==1){box2=die4;}
				if(i==2){box3=die4;}
				if(i==3){box4=die4;}
				if(i==4){box5=die4;}
				if(i==5){box6=die4;}
			}
			if((int)diceRolls[i]==5)
			{
				if(i==0){box1=die5;}
				if(i==1){box2=die5;}
				if(i==2){box3=die5;}
				if(i==3){box4=die5;}
				if(i==4){box5=die5;}
				if(i==5){box6=die5;}
			}
			if((int)diceRolls[i]==6)
			{
				if(i==0){box1=die6;}
				if(i==1){box2=die6;}
				if(i==2){box3=die6;}
				if(i==3){box4=die6;}
				if(i==4){box5=die6;}
				if(i==5){box6=die6;}
			}
		}
	}
}
