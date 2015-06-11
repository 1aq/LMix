﻿using UnityEngine;
using System.Collections;

public class SpinnerGenerator : MonoBehaviour
{
	public GameObject spinner;
	// Use this for initialization
	void Start ()
	{
		//InvokeRepeating ("Generate", 0, 1);	// Generate() need be private
		//Generate (3);
	}

	public void Generate (float time)
	{
		(((GameObject)Instantiate (spinner)).GetComponent ("Spin") as Spin).TotalTime = time;
	}
}
