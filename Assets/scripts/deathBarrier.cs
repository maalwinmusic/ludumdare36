﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class deathBarrier : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}