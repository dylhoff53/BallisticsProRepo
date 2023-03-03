using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Launcher : MonoBehaviour
{

    public int numOfPro = 0;
    public GameObject target;
    public float launchForce = 10f;
    public GameObject[] projects;
    public Transform startPos;
    public GameObject missle;
    public void Fire()
    {
        if (numOfPro < 4)
        {
            FiringSolution fs = new FiringSolution();
            Nullable<Vector3> aimVector = fs.Calculate(transform.position, target.transform.position, launchForce, Physics.gravity);
            if (aimVector.HasValue)
            {
                GameObject missleObj = Instantiate(missle, startPos.position, Quaternion.identity);
                projects[numOfPro] = missleObj;
                projects[numOfPro].GetComponent<Rigidbody>().AddForce(aimVector.Value.normalized * launchForce, ForceMode.VelocityChange);
                numOfPro++;
            }
        }
    }
}
