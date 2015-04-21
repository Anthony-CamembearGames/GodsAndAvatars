using UnityEngine;
using System.Collections;

public class ZoomFunction : MonoBehaviour {

	void Update ()
		
	{
		
		//------------------Code for Zooming Out------------
		
		if (Input.GetAxis ("Mouse ScrollWheel") < 0)

		{			
			if (Camera.main.fieldOfView<=100)
				Camera.main.fieldOfView +=2f;
			if (Camera.main.orthographicSize<=20)
				Camera.main.orthographicSize +=0.5f;
		}
		
		if (Input.GetAxis("Mouse ScrollWheel") > 0)

		{
			if (Camera.main.fieldOfView>2)
				Camera.main.fieldOfView -=2f;
			if (Camera.main.orthographicSize>=1)
				Camera.main.orthographicSize -=0.5f;
		}
		
	
}
}