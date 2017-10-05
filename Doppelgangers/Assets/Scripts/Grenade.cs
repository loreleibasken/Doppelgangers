using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {

    public Rigidbody2D grenade;                
    public float projSpeed = 20f;            
    public Vector3 Rotation;              
    private Movement playerMove;
    
    void Update()
    {
        // Check to see if Fire 1 is pressed
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate an arrow!
            Rigidbody2D grenadeInstance = Instantiate(grenade, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
            grenadeInstance.velocity = new Vector2(projSpeed, 0);
        }
    }

    /*
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        
    }
    */
}
