using UnityEngine;
using System.Collections;

public class movingPlatform : MonoBehaviour {

	[SerializeField]
	private GameObject a;
	[SerializeField]
	private GameObject b;

	bool right;

	void FixedUpdate()
	{
		if (this.gameObject.transform.position == b.transform.position) {
			right = false;
		}
		if (this.gameObject.transform.position == a.transform.position) {
			right = true;
		}
		if (right) {
			this.gameObject.transform.position = Vector2.MoveTowards (this.gameObject.transform.position, b.transform.position, 0.025f);
		} else {
			this.gameObject.transform.position = Vector2.MoveTowards (this.gameObject.transform.position, a.transform.position, 0.025f);
		}
	}
}