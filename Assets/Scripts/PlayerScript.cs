using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Action_Menu action_Menu;

	public int player_x, player_y;
	

	void Awake () {
		action_Menu = GetComponent<Action_Menu> ();
		this.transform.parent = GameObject.Find("Board").transform;

		}

	void OnMouseDown() {
		float x = this.transform.position.x;
		float y = this.transform.position.y;
		action_Menu.create_menu (x,y);
	}

}
