using UnityEngine;
using System.Collections;

public class boulderMovement : MonoBehaviour {

	[SerializeField]
	private float speed;

	public bool goTheOtherWay;

	void FixedUpdate()
	{
		if (!goTheOtherWay) {
			this.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (1 * speed, this.gameObject.GetComponent<Rigidbody2D> ().velocity.y);
		} else {
			this.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-1 * speed, this.gameObject.GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
}