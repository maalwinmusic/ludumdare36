using UnityEngine;
using System.Collections;

public class axeRotate : MonoBehaviour {

	void FixedUpdate()
	{
		this.gameObject.transform.Rotate (new Vector3 (0, 0, -3), Space.Self);
	}

}