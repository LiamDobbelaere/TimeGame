using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AC.TimeOfDaySystemFree;

public class SetTextToTime : MonoBehaviour {
	private Text myText;
	private TimeOfDayManager timeScript;

	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> ();
		timeScript = GameObject.Find ("TimeManager").GetComponent<TimeOfDayManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		int hours = (int)Mathf.Floor (timeScript.timeline);
		int minutes = (int) ((timeScript.timeline - (int)Mathf.Floor (timeScript.timeline)) * 60.0f);

		myText.text = hours.ToString("00") + ":" + minutes.ToString("00");
	}
}
