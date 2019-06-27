using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public abstract class PaddleController : NetworkBehaviour {

	public float speed = 5f;

	public int maxField = 4;

	public void Update () {
		
		if (!isLocalPlayer) {
			return;
		}

		this.transform.position = new Vector3 (transform.position.x,
			Mathf.Clamp (transform.position.y, -maxField, maxField));
	}

	protected void MoveUp() {
		if (!isLocalPlayer) {
			return;
		}

		transform.Translate(new Vector3(0f, speed * Time.deltaTime));
	}

	protected void MoveDown() {

		if (!isLocalPlayer) {
			return;
		}

		transform.Translate(new Vector3(0f, -speed * Time.deltaTime));
	}
}

