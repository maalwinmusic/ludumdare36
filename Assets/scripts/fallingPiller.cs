using UnityEngine;
using System.Collections;

public class fallingPiller : MonoBehaviour {

	[SerializeField]
	private Rigidbody2D rb;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			GameObject.Find ("player").GetComponent<controller> ().canControll = false;
			//GameObject.Find ("player").GetComponent<controller> ().rb.velocity = new Vector2 (0, GameObject.Find ("player").GetComponent<controller> ().rb.velocity.y);
			GameObject.Find ("player").GetComponent<CircleCollider2D> ().isTrigger = true;
			rb.gravityScale = 1;
		}
	}
}