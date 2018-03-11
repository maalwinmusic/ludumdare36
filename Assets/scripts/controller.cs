using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

	[SerializeField]
	private float speed;

	[SerializeField]
	public Rigidbody2D rb;

	private bool isGrounded;
	private bool shouldJump;

	public bool canControll = true;

	void Update()
	{
		if (Input.GetKey (KeyCode.Space)) {
			shouldJump = true;

			if (shouldJump) {
				if (isGrounded) {
					rb.AddForce (new Vector2 (0, 250));
					isGrounded = false;
				}
				shouldJump = false;
			}
		}
	}

	void FixedUpdate()
	{
		if (canControll) {
			Vector2 velocity = new Vector2 (Input.GetAxis ("Horizontal") * speed, rb.velocity.y);
			rb.velocity = velocity;


		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.layer == 8) {
			isGrounded = true;
		}
	}


}