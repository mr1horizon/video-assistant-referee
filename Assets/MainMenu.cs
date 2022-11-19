using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void ExitButton () {
		Application.Quit();
		Debug.Log("Game Exit");
	}
	public void StartAustria () {
		SceneManager.LoadScene("Austria");
	}
	public void StartMonaco () {
		SceneManager.LoadScene("Monaco");
	}

}
