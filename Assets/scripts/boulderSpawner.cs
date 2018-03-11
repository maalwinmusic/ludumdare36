using UnityEngine;
using System.Collections;

public class boulderSpawner : MonoBehaviour {

	[SerializeField]
	private GameObject boulder;
	[SerializeField]
	private cameraShake shake;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			shake.StartShake ();
			Instantiate (boulder, new Vector2 (-22, -7.5f), Quaternion.identity);
		}
	}
}