using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour {

	void Start()
	{
		StartCoroutine (Ending ());
	}

	IEnumerator Ending()
	{
		yield return new WaitForSeconds (0.25f);
		SceneManager.LoadScene (0);
	}
}