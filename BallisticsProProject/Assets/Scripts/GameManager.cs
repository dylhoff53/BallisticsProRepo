using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public float count = 1;
    public int numbOfBlocks = 0;
    public float funny;
    public Transform first;
    public Vector3 nextDrop;
    public bool noCords = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BlockCountdown();
    }

    public void BlockCountdown()
    {
        if(count > 0)
        {
            count -= funny * Time.deltaTime * 4;
        } else if( count == 0.5 || count < .5 && noCords == true)
        {
            noCords = false;
            nextDrop = new Vector3(Random(0,6), 3, Random(0, 6));
        } else if(count == 0 || count < 0)
        {
            count = 1;
            if(numbOfBlocks == 0)
            {
                numbOfBlocks++;
                GameObject bloc = Instantiate(block, first.position, Quaternion.identity);
                noCords = true;
            } else
            {
                numbOfBlocks++;
                GameObject bloc = Instantiate(block, nextDrop, Quaternion.identity);
                noCords = true;
            }
        }
    }

    private float Random(int v1, int v2)
    {
        throw new NotImplementedException();
    }
}
