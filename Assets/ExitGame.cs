using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
	        {
			LapTimeManager.MinuteCount = 0;
		      LapTimeManager.SecondCount = 0;
		      LapTimeManager.MilliCount = 0;
			SceneManager.LoadScene("Menu");
	        }
		if (Input.GetKeyDown(KeyCode.R))
		{
	  LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
