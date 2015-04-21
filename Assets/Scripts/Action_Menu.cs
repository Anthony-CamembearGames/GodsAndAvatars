using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Action_Menu : MonoBehaviour {

	public GameObject Movement_prefab;
	private GameObject mov_menu;

	public void create_menu(float x, float y){
		mov_menu = Instantiate (Movement_prefab, new Vector3 (x+1f, y, -2f), Quaternion.identity) as GameObject;
		mov_menu.transform.parent = GameObject.Find("Player(Clone)").transform;
		mov_menu.transform.localScale = new Vector3( 1f, 1f, 0f);

	}
}


