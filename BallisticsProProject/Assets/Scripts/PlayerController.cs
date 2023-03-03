using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rig;
    public float moveSpeed;
    public 

    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }

    public void Move()
    {
            // get the input axis
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            // calculate a direction relative to where we're facing
            Vector3 dir = (transform.forward * z + transform.right * x) * moveSpeed;
            dir.y = rig.velocity.y;

            // set that as our velocity
            rig.velocity = dir;
    }

}
