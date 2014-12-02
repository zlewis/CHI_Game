using UnityEngine;
using System.Collections;

public class MonsterScript : MonoBehaviour {

	public int victoryPoints; 
	public int energy; 
	public int health;
	public bool inCity=false;
	public Vector3 basicPos;
	private int numberOfMonsters; 	//used to change layout of monsters stats 

	private bool isAlive; 

	// Use this for initialization
	void Start () {
		victoryPoints = 0; 
		energy = 0; 
		health = 10; 
		isAlive = true; 
		numberOfMonsters = 6; //six for now... unless we can change the number of players 
		basicPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//guiText.text = "Test " + health; 
	}

	//Methods for victoryPoints 
	public void addPoints(int num){
		victoryPoints += num; 
		//wins if points >= 20 
	}

	public void losePoints(int num){
		victoryPoints -= num; 
	}

	//Methods for energy 
	public void addEnergy(int num){
		energy += num; 
	}

	public void loseEnergy(int num){
		energy -= num; 
	}

	//Methods for health 
	public void addHealth(int num){
		if (health < 10){ 
			health += num;
		}
	}

	public void loseHealth(int num){
		health -= num; 
		if (health <= 0) {
			isAlive = false; 
		}
	}

	//Method for isAlive
	public bool monsterAlive(){
		return isAlive; 
	}
}
