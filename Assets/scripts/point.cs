using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class point : MonoBehaviour {

	[SerializeField]
	private Text text;
	public int seconds = 0;

	void Awake()
	{
		InvokeRepeating ("AddSecond", 0, 1);
	}

	void AddSecond()
	{
		seconds++;
		text.text = seconds.ToString ();
	}
}