using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationManager : MonoBehaviour {

	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			print ("A");
			Vibration.Vibrate (30);
		}
	}

}
