using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerController : PaddleController {

	public void Update () {
		base.Update ();

		if (Input.GetKey (KeyCode.UpArrow)) {
			
			MoveUp();
		} else if(Input.GetKey(KeyCode.DownArrow)) {
			
			MoveDown();
		}
	}
}
