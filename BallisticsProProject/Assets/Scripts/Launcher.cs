using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Launcher : MonoBehaviour
{
    public GameObject target;
    public float launchForce = 10f;
    public Transform startPos;
    public GameObject missle;
    public GameManager gm;
    public Vector3 playerPosition;
    public Vector3 closetTarget;
    public int targetCount;
    public void Fire()
    {
        /*       foreach(GameObject target in gm.targets)
               {
                   if(target != null)
                   {
                       if(targetCount == 0)
                       {
                           closetTarget = gm.targets[targetCount].transform.position;
                           targetCount++;
                       } else if (playerPosition - gm.targets[targetCount].transform.position < playerPosition - closetTarget)
                       {

                       }
                   }
               } */
        FiringSolution fs = new FiringSolution();
        Nullable<Vector3> aimVector = fs.Calculate(transform.position, target.transform.position + target.GetComponent<Kinematic>().linearVelocity, launchForce, Physics.gravity);
        if (aimVector.HasValue)
        {
            GameObject missleObj = Instantiate(missle, startPos.position, Quaternion.identity);
            missleObj.GetComponent<Missle>().launcher = this;
            missleObj.GetComponent<Rigidbody>().AddForce(aimVector.Value.normalized * launchForce, ForceMode.VelocityChange);
        }
    }
}
