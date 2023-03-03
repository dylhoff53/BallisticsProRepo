using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    public GameObject block;
    public bool isFalling = true;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player" && isFalling == true)
        {
            
        } else if(collision.collider.tag == "Ground")
        {
            isFalling = false;
        }
    }
}
