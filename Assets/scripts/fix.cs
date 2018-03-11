using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class fix : MonoBehaviour {

	void Start()
	{
		SceneManager.LoadScene (3);
	}
}