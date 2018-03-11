using UnityEngine;
using System.Collections;

public class arrowTrap : MonoBehaviour {

	[SerializeField]
	private GameObject arrow;
	[SerializeField]
	private float time;

	void Awake()
	{
		InvokeRepeating ("FireArrow", 0, time);
	}

	void FireArrow()
	{
		Instantiate (arrow, this.transform.position, Quaternion.identity);
	}
}
