using UnityEngine;
using System.Collections;

public class GUI_game : MonoBehaviour {

	
	void OnGUI () {
		GameObject GameManager = GameObject.Find ("GameManager");

		// Make a background box
		GUI.Box(new Rect(10,10,100,50), "Menu");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "End Turn")) {
			if (GameManager.GetComponent<gameManager>().is_player_turn) {
				GameManager.GetComponent<gameManager>().is_player_turn = false;
			}
			else{
				GameManager.GetComponent<gameManager>().is_player_turn = true;
			}
		}

	}
}
