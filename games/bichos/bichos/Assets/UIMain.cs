using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour {

	int bichos1;
	int bichos2;
	int bichos3;

	public Text bicho1;
	public Text bicho2;
	public Text bicho3;

	void Start()
	{
		Events.CaptureBicho += CaptureBicho;
		UpdateFields ();
	}
	void CaptureBicho(Bicho bicho)
	{
		switch (bicho.id){
		case 1:
			bichos1++;
			break;
		case 2:
			bichos2++;
			break;
		case 3:
			bichos3++;
			break;
		}
		UpdateFields ();
	}
	public void UpdateFields()
	{
		bicho1.text = bichos1.ToString();
		bicho2.text = bichos2.ToString();
		bicho3.text = bichos3.ToString();
	}
}
