using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

	[SerializeField]
	private Text highscore;

	void Awake()
	{
		highscore.text = PlayerPrefs.GetInt ("highscore", 0).ToString();
	}

	public void StartGame()
	{
		SceneManager.LoadScene (1);
	}

	public void EndGame(){
		Application.Quit ();
	}

	public void Hardest()
	{
		SceneManager.LoadScene ("HARD");
	}
}