using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    public float jumpheight;

    public bool grounded;

    public Rigidbody2D clone1, clone2;

    private void Start()
    {
        grounded = false;
    }

    //private void Awake()
    //{
    //    clone1 = GameObject.Find("Player1").transform.Find("clone1").GetComponent<Rigidbody2D>;
    //}

    void Update ()
    {

        if (grounded)
        {
            clone1.velocity = new Vector2(0, 0);
            clone2.velocity = new Vector2(0, 0);

            clone1.gravityScale = 0;
            clone2.gravityScale = 0;
        }

        if (!grounded)
        {
            clone1.gravityScale = 1;
            clone2.gravityScale = -1;
        }
   
        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpheight));
        }
    }
}
