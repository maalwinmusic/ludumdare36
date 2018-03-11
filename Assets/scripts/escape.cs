using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class escape : MonoBehaviour {

	public void Return()
	{
		Destroy (this.gameObject);
		SceneManager.LoadScene (0);
	}
}