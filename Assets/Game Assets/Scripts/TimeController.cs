using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {
	private Light lightComponent;
	private Vector3 lightAngles;

	// Use this for initialization
	void Start () {
		lightComponent = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		lightAngles.x = lightAngles.x + 0.5f;
		lightAngles.y = 180;
		lightAngles.z = 180;

		transform.rotation = Quaternion.Euler (lightAngles);
	}
}
