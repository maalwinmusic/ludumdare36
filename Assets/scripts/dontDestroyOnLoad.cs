using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class dontDestroyOnLoad : MonoBehaviour {

	[SerializeField]
	private point p;

	void Awake()
	{
		DontDestroyOnLoad (this.gameObject);
	}

	void Update()
	{
		if (SceneManager.GetActiveScene ().name == "ending") {
			if (PlayerPrefs.GetInt ("highscore", 0) != 0) {
				if (PlayerPrefs.GetInt ("highscore", 0) > p.seconds) {
					PlayerPrefs.SetInt ("highscore", p.seconds);
				}
			} else {
				PlayerPrefs.SetInt ("highscore", p.seconds);
			}
			Destroy (this.gameObject);
		}
	}
}