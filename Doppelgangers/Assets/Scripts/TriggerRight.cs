using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRight : MonoBehaviour {

    void OnTriggerEnter2D()
    {
        Debug.Log("test");
        //this.parent.gameObject.GetComponent<Movement>().rightobstacle = true;
    }

    void OnTriggerExit()
    {
        transform.parent.gameObject.GetComponent<Movement>().rightobstacle = false;
    }
}
