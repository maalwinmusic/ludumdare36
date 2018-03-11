using UnityEngine;
using System.Collections;

public class torchScript : MonoBehaviour {

	[SerializeField]
	private GameObject torch1;
	[SerializeField]
	private GameObject torch2;

	void Awake()
	{
		InvokeRepeating ("Switch", 0, 0.25f);
	}

	void Switch()
	{
		if (!torch1.activeSelf) {
			torch1.SetActive (true);
			torch2.SetActive (false);
		} else {
			torch1.SetActive (false);
			torch2.SetActive (true);
		}
	}
}