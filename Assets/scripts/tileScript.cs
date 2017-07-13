﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileScript : MonoBehaviour {

    public Vector3 currentTile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {

        gridScript.instance.currentTileVector = this.gameObject.transform.position;
        
    }

    private void OnMouseExit()
    {
        gridScript.instance.currentTileVector = Vector3.zero;
    }

}
