using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    public GameObject thing;
    public Launcher launcher;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(thing);
        if(collision.collider.tag == "Boss")
        {
            collision.collider.GetComponent<Boss>().LossHP();
        }
    }
}
