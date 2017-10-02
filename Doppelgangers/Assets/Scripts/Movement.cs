using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    public bool rightobstacle, leftobstacle;

    private void Start()
    {
        rightobstacle = false;
        leftobstacle = false;
    }

    private void Update()
    {
        Vector2 current_position = this.transform.position;
        if(Input.GetKey(KeyCode.D) && !rightobstacle)
        {
            current_position.x += speed *Time.deltaTime;
            this.transform.position = current_position;
        }
        if (Input.GetKey(KeyCode.A) && !leftobstacle)
        {
            current_position.x -= speed * Time.deltaTime;
            this.transform.position = current_position;
        }
    }

}
