using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationManager : MonoBehaviour {

	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			Vibration.Vibrate (100);
		}
	}

}
