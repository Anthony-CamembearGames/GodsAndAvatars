using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Action_Mov : MonoBehaviour {

	public int x_actual, y_actual;
	public GameObject selection_prefab;
	public GameObject not_selection_prefab;
	private Transform selection_holder;              


	
	GameObject board;

	void Start(){
		board = GameObject.Find("GameManager");
	}

	void OnMouseDown() {



		if (this.transform.parent.name == "Player(Clone)") {
			x_actual = transform.parent.GetComponent<PlayerScript> ().player_x;
			y_actual = transform.parent.GetComponent<PlayerScript> ().player_y;
		}
		if (this.transform.parent.name == "Enemy(Clone)") {
			x_actual = transform.parent.GetComponent<EnemyScript> ().enemy_x;
			y_actual = transform.parent.GetComponent<EnemyScript> ().enemy_y;
		}

		BoardManager board_tiles_generated = board.GetComponent<BoardManager> ();

		selection_holder = new GameObject ("Selection_Holder").transform;

		this.transform.SetParent (selection_holder);

		for (int i=0; i < board_tiles_generated.Tiles_generated.Count; i++) {

			Tile_Script instantiated_tile = board_tiles_generated.Tiles_generated[i].GetComponent<Tile_Script>();

			if(Mathf.Abs(instantiated_tile.x_grid-x_actual) + Mathf.Abs(instantiated_tile.y_grid-y_actual)<=1 && Mathf.Abs(instantiated_tile.x_grid-x_actual) + Mathf.Abs(instantiated_tile.y_grid-y_actual)>0) 
			{
				GameObject selected = Instantiate (selection_prefab, new Vector3 (instantiated_tile.transform.position.x, instantiated_tile.transform.position.y+0.15f, -0f), Quaternion.identity) as GameObject;

				selected.transform.SetParent(selection_holder);

				Selection_Script selected_s = selected.GetComponent<Selection_Script>();
				selected_s.x_grid =instantiated_tile.x_grid;
				selected_s.y_grid =instantiated_tile.y_grid;

			}
			else if (Mathf.Abs(instantiated_tile.x_grid-x_actual) + Mathf.Abs(instantiated_tile.y_grid-y_actual)==0)
			{

			}
			else
			{
				GameObject not_selected = Instantiate (not_selection_prefab, new Vector3 (instantiated_tile.transform.position.x, instantiated_tile.transform.position.y+0.15f, -0f), Quaternion.identity) as GameObject;

				not_selected.transform.SetParent(selection_holder);

				Selection_Script selected_s = not_selected.GetComponent<Selection_Script>();
				selected_s.x_grid =instantiated_tile.x_grid;
				selected_s.y_grid =instantiated_tile.y_grid;
			}

		}
		//Destroy (gameObject);
		}


	}

