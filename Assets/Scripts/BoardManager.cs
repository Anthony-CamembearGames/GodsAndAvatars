using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

	public GameObject TilePrefab;
	public GameObject PlayerPrefab;
	public GameObject EnemyPrefab;


	private Transform boardHolder;              
	private GameObject tile;

	private GameObject player;
	private GameObject enemy;


	public Tile_Script tileScript;
	public List<GameObject> Tiles_generated = new List<GameObject>();

	public List<GameObject> read_list(){
		return Tiles_generated;
	}

	public void Place_Tile()

	{
		boardHolder = new GameObject ("Board").transform;

		for (int a=0; a < 4; a++) {
			for (int b=0; b < 4; b++) {

				float X = 0f + (b * 3.05f) - a * (3.05f);
				float Y = 0f + (b * 1.6f) + a * (1.6f);
				create_tile(X, Y, a, b);
			}
		}
	}

	public void create_Player(int x, int y){

		for (int i=0; i < Tiles_generated.Count; i++) {
			Tile_Script instantiated_tile = Tiles_generated[i].GetComponent<Tile_Script>();
			if(instantiated_tile.x_grid == x  &&  instantiated_tile.y_grid == y) {

				float x_pos = instantiated_tile.transform.position.x+0f;
				float y_pos = instantiated_tile.transform.position.y+1f;

				player = Instantiate (PlayerPrefab, new Vector3 (x_pos, y_pos, -1f), Quaternion.identity) as GameObject;

				PlayerScript instantiated_player = player.GetComponent<PlayerScript>();


				instantiated_player.player_x = x;
				instantiated_player.player_y = y;

			}
		}
	}

	public void create_Enemy(int x, int y){
		
		for (int i=0; i < Tiles_generated.Count; i++) {
			Tile_Script instantiated_tile = Tiles_generated[i].GetComponent<Tile_Script>();
			if(instantiated_tile.x_grid == x  &&  instantiated_tile.y_grid == y) {
				
				float x_pos = instantiated_tile.transform.position.x+0f;
				float y_pos = instantiated_tile.transform.position.y+1f;
				
				enemy = Instantiate (EnemyPrefab, new Vector3 (x_pos, y_pos, -1f), Quaternion.identity) as GameObject;
				
				EnemyScript instantiated_enemy = enemy.GetComponent<EnemyScript>();

				instantiated_enemy.enemy_x = x;
				instantiated_enemy.enemy_y = y;
				
			}
		}
	}
	
	private void create_tile(float x, float y, int xgrid, int ygrid)
	
	{
		tile = Instantiate (TilePrefab, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject;
		tile.transform.SetParent(boardHolder);

		Tiles_generated.Add (tile);

		Tile_Script instantiated_tile = tile.GetComponent<Tile_Script>();

		instantiated_tile.x_grid = xgrid;
		instantiated_tile.y_grid = ygrid;

	}
}
