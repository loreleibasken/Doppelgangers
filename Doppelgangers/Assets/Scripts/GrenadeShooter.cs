using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeShooter : MonoBehaviour
{

    public Rigidbody2D grenade;
    public float speed = 20;

	
	void Start ()
    {
		
	}
	

	void Update ()
    {
		if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D instantiatedGrenade = Instantiate(grenade, transform.position, transform.rotation);
            instantiatedGrenade.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }
	}
}
