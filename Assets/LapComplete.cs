using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

	List<float> bestTimes = new List<float>();

    void OnTriggerEnter () {
		float elapsedTime = LapTimeManager.MinuteCount * 600 + LapTimeManager.SecondCount * 10 + LapTimeManager.MilliCount;
		bestTimes.Add(elapsedTime);
		if (bestTimes.Count > 0)
		{
			bestTimes.Sort();
			LapTimeManager.MinuteCount = (int)(bestTimes[0]/600);
			LapTimeManager.SecondCount = (int)((bestTimes[0] - (LapTimeManager.MinuteCount*600))/10);
			LapTimeManager.MilliCount = (int)(bestTimes[0] - (LapTimeManager.MinuteCount*600) - (LapTimeManager.SecondCount*10));
		}
        if(LapTimeManager.SecondCount <= 9) {
			SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else {
			SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }
        if(LapTimeManager.MinuteCount <= 9) {
			MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else {
			MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
        }
        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

        HalfLapTrig.SetActive (true);
        LapCompleteTrig.SetActive (false);
    }
}
