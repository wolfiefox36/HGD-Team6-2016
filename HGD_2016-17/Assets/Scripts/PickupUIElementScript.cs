﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickupUIElementScript : MonoBehaviour {

    public Text countText;
    public GameObject player;
    public PickupScript.PickupType type;

    private int count 
    {
        get 
        {
            PlayerMovementScript ps = player.GetComponent<PlayerMovementScript>();
            return ps.pickupDictionary.ContainsKey(type) ? ps.pickupDictionary[type] : 0;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        countText.text = ": " + count;
	}
}
