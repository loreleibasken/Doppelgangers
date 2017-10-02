using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLeft : MonoBehaviour {

    public GameObject current_player;

    private void Awake()
    {
        current_player = GameObject.Find("Player1");
    }

    void OnTriggerEnter2D()
    {
        current_player.GetComponent<Movement>().leftobstacle = true;
    }

    void OnTriggerExit2D()
    {
        current_player.GetComponent<Movement>().leftobstacle = false;
    }

}
