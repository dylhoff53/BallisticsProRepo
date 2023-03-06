using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int bossHP;
    public GameObject boss;

    public void LossHP()
    {
        bossHP--;
        if(bossHP < 1)
        {
            Destroy(boss);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            Destroy(collision.collider);
        }
    }
}
