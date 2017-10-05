using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {

    public Rigidbody2D arrow;                
    public float projSpeed = 20f;            
    public Vector3 Rotation;              
    private Movement playerMove;
    

    void Awake()
    {
        // Setting up the references required
        // playerMove = transform.root.GetComponent<PlayerMovement>();
    }

    

    
    void Update()
    {
        // Check to see if Fire 1 is pressed
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate an arrow!
            Rigidbody2D arrowInstance = Instantiate(arrow, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
            arrowInstance.velocity = new Vector2(projSpeed, 0);
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
