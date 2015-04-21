using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Action_Mov : MonoBehaviour {

	public int x_actual, y_actual;
	public GameObject selection_prefab;
	public GameObject not_selection_prefab;

	
	GameObject board;

	void Start(){
		board = GameObject.Find("GameManager");

	}

	void OnMouseDown() {

		x_actual = transform.parent.GetComponent<PlayerScript>().player_x;
		y_actual = transform.parent.GetComponent<PlayerScript>().player_y;

		BoardManager board_tiles_generated = board.GetComponent<BoardManager> ();

		for (int i=0; i < board_tiles_generated.Tiles_generated.Count; i++) {

			Tile_Script instantiated_tile = board_tiles_generated.Tiles_generated[i].GetComponent<Tile_Script>();

			if(Mathf.Abs(instantiated_tile.x_grid-x_actual) + Mathf.Abs(instantiated_tile.y_grid-y_actual)<=1 && Mathf.Abs(instantiated_tile.x_grid-x_actual) + Mathf.Abs(instantiated_tile.y_grid-y_actual)>0) 
			{
				GameObject selected = Instantiate (selection_prefab, new Vector3 (instantiated_tile.transform.position.x, instantiated_tile.transform.position.y+0.15f, -0f), Quaternion.identity) as GameObject;
				Selection_Script selected_s = selected.GetComponentsInParent<Selection_Script>();
				selected_s.x_grid =instantiated_tile.x_grid;
				selected_s.y_grid =instantiated_tile.y_grid;

				selected_s.Read_pos();
				//print (selected_s.x_grid);

			}
			else if (Mathf.Abs(instantiated_tile.x_grid-x_actual) + Mathf.Abs(instantiated_tile.y_grid-y_actual)==0)
			{

			}
			else
			{
				GameObject not_selected = Instantiate (not_selection_prefab, new Vector3 (instantiated_tile.transform.position.x, instantiated_tile.transform.position.y+0.15f, -0f), Quaternion.identity) as GameObject;
				Selection_Script selected_s = not_selected.GetComponent<Selection_Script>();
				selected_s.x_grid =instantiated_tile.x_grid;
				selected_s.y_grid =instantiated_tile.y_grid;
			}

		}
		//Destroy (gameObject);
		}


	}

