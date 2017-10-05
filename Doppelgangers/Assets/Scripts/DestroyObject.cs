using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    private Transform _transform;

    
    void Start ()
    {
        _transform = transform;

        Destroy(gameObject, 2);
    }
	
	
	void Update ()
    {
		
	}
}
