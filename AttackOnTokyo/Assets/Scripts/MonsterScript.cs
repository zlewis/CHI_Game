using UnityEngine;
using System.Collections;

public class MonsterScript : MonoBehaviour {

	public int victoryPoints; 
	public int energy; 
	public int health; 

	private bool isAlive; 

	// Use this for initialization
	void Start () {
		victoryPoints = 0; 
		energy = 0; 
		health = 10; 
		isAlive = true; 
	}
	
	// Update is called once per frame
	void Update () {
		//guiText.text = "Test " + health; 
	}

	//Methods for victoryPoints 
	void addPoints(int num){
		victoryPoints += num; 
		//wins if points >= 20 
	}

	void losePoints(int num){
		victoryPoints -= num; 
	}

	//Methods for energy 
	void addEnergy(int num){
		energy += num; 
	}

	void loseEnergy(int num){
		energy -= num; 
	}

	//Methods for health 
	void addHealth(int num){
		if (health < 10){ 
			health += num;
		}
	}

	void loseHealth(int num){
		health -= num; 
		if (health <= 0) {
			isAlive = false; 
		}
	}

	//Method for isAlive
	bool monsterAlive(){
		return isAlive; 
	}
}
