using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameManager : MonoBehaviour {

	public BoardManager boardScript;
	public int player_pos_x, player_pos_y;
	public int enemy_pos_x, enemy_pos_y;


	public bool is_player_turn = false;



	void Awake () {

		is_player_turn = true;
		boardScript = GetComponent<BoardManager> ();
		InitGame ();
	}

	void InitGame(){

		boardScript.Place_Tile ();
		boardScript.create_Player (player_pos_x-1,player_pos_y-1);
		boardScript.create_Enemy (enemy_pos_x-1,enemy_pos_y-1);

	}


}
