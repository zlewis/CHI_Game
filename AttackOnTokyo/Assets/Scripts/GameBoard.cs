﻿using UnityEngine;
using System.Collections;

public class GameBoard : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
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
    }
}
