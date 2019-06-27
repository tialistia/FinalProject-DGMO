using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Ball : NetworkBehaviour {

	private bool started = false;
	private Rigidbody2D rigidBody;
	private ScoreManager scoreManager;
	private PongNetworkManager networkManager;

	void Start () {
		scoreManager = FindObjectOfType<ScoreManager> ();
		rigidBody = GetComponent<Rigidbody2D> ();
		networkManager = FindObjectOfType<PongNetworkManager> ();
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "PlayerOneGoal") {
			Respawn ();
			scoreManager.PlayerTwoScores ();
		} else if (col.gameObject.tag == "PlayerTwoGoal") {
			Respawn ();
			scoreManager.PlayerOneScores ();
		}
	}

	private void Respawn() {
		started = false;
		this.transform.position = new Vector2 (0f, 0f);
		rigidBody.velocity = Vector2.zero;
	}
}
