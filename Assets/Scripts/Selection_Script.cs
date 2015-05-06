using UnityEngine;
using System.Collections;

public class Selection_Script : MonoBehaviour {

	public Sprite initial,hover_over;
	public int x_grid;
	public int y_grid;


	void Awake(){
		//print (x_grid);
	}

	public void Read_pos(){
		print (x_grid);
	}

	void OnMouseOver() {
		gameObject.GetComponent<SpriteRenderer>().sprite = hover_over;
	}
	
	// to reset:

	void OnMouseExit() {
		gameObject.GetComponent<SpriteRenderer>().sprite = initial;
	}

	void OnMouseDown() {

		GameObject player = GameObject.Find ("Player(Clone)");
		GameObject Selection_Holder = GameObject.Find("Selection_Holder");

		PlayerScript player_place = player.GetComponent<PlayerScript>();

		float x_pos = this.transform.position.x+0f;
		float y_pos = this.transform.position.y+1f;
		
		//print (this.x_grid);
		
		if(Mathf.Abs(player_place.player_x-x_grid) + Mathf.Abs(player_place.player_y-y_grid)<=1 && Mathf.Abs(player_place.player_x-x_grid) + Mathf.Abs(player_place.player_y-y_grid)>0) 
		{
			player.transform.position = new Vector3(x_pos, y_pos, -1f);

			player_place.player_x = x_grid;
			player_place.player_y = y_grid;

			Destroy(Selection_Holder);
		}

		else if (Mathf.Abs(x_grid-player_place.player_x) + Mathf.Abs(y_grid-player_place.player_y)==0)
		{

		}
		else
		{

		}



	}

}
