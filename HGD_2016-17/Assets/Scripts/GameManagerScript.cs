﻿using UnityEngine;
using System.Collections;
using System.IO;

public class GameManagerScript : MonoBehaviour {

	public bool isPaused = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        Time.timeScale = isPaused ? 0 : 1;
    }
}
