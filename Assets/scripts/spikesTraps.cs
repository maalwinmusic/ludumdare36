using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spikesTraps : MonoBehaviour {

	void Awake()
	{
		StartCoroutine ("SpawningAtRandom");
	}

	IEnumerator SpawningAtRandom()
	{
		int random = Random.Range (0, 5);
		yield return new WaitForSeconds (random);
		this.gameObject.GetComponent<Animation> ().Play ();
	}
}