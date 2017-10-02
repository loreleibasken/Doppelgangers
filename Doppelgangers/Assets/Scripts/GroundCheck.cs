using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    public GameObject current_player_rb1, current_player_rb2;

    //private void Awake()
    //{
    //    current_player_rb1 = GameObject.Find("clone1");
    //    current_player_rb2 = GameObject.Find("clone2");
    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            current_player_rb1.GetComponent<Jump>().grounded = true;
            current_player_rb2.GetComponent<Jump>().grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            current_player_rb1.GetComponent<Jump>().grounded = false;
            current_player_rb2.GetComponent<Jump>().grounded = false;
        }
    }
}
