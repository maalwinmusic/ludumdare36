﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class outro : MonoBehaviour {

	[SerializeField]
	private float time;

	void Awake()
	{
		StartCoroutine (StartGame());
	}

	IEnumerator StartGame()
	{
		yield return new WaitForSeconds (time);
		SceneManager.LoadScene ("ending");
	}
}