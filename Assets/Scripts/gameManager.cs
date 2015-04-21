using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameManager : MonoBehaviour {

	public BoardManager boardScript;
	public int player_pos_x, player_pos_y;



	void Awake () {
		boardScript = GetComponent<BoardManager> ();

		InitGame ();
	}

	void InitGame(){
		boardScript.Place_Tile ();
		boardScript.create_Player (player_pos_x-1,player_pos_y-1);



		//Tile_Script instantiated_tile = boardScript.Tiles_generated[6].GetComponent<Tile_Script>();

		//Debug.Log (instantiated_tile.x_grid);

	}


}
