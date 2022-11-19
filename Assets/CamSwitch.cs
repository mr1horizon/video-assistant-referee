using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("1Key"))
	  {
		cam1.SetActive(true);
		cam1.GetComponent<AudioListener>().enabled  = true;
		cam2.SetActive(false);
		cam2.GetComponent<AudioListener>().enabled  = false;

        }
        if (Input.GetButtonDown("2Key"))
	  {
		cam1.SetActive(false);
		cam1.GetComponent<AudioListener>().enabled  = false;

		cam2.SetActive(true);
		cam2.GetComponent<AudioListener>().enabled  = true;

        }
    }
}
