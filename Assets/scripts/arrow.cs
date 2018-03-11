using UnityEngine;
using System.Collections;

public class arrow : MonoBehaviour {

	void Update()
	{
		if (this.transform.position.y < -11) {
			Destroy (this.gameObject);
		}
	}
}