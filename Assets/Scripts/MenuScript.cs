﻿using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void clickPlay() {
		Application.LoadLevel ("Play");
	}

	public void clickOption() {
		Application.LoadLevel ("Option");
	}
}	
