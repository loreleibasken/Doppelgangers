﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRight : MonoBehaviour {

    public GameObject current_player;

    private void Awake()
    {
        current_player = GameObject.Find("Player1");
    }

    void OnTriggerEnter2D()
    {
        current_player.GetComponent<Movement>().rightobstacle = true;
    }

    void OnTriggerExit2D()
    {
        current_player.GetComponent<Movement>().rightobstacle = false;
    }
}
