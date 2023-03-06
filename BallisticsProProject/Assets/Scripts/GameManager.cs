using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public float count = 1f;
    public int numbOfBlocks = 0;
    public float funny;
    public Transform first;
    public Vector3 nextDrop;
    public bool noCords = true;
    public List<GameObject> targets;
    public float enemySpawnCount = 1;
    public GameObject Enemy;
    public int numberofEnemies;

    private void Awake()
    {
        targets = new List<GameObject>();
    }
    // Update is called once per frame
    void Update()
    {
        BlockCountdown();
     // EnemySpawning();
    }

    public void BlockCountdown()
    {
        if(count > 0f)
        {
            count -= funny * Time.deltaTime * 4;
        } else if( count == 0.5f || count < .5f && noCords == true)
        {
            noCords = false;
            nextDrop = new Vector3(Random.Range(0,6), 3, Random.Range(0, 6));
        } else if(count == 0f || count < 0f)
        {
            count = 1f;
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

 /*   public void EnemySpawning()
    {
        if(enemySpawnCount > 0)
        {
            enemySpawnCount -= funny * Time.deltaTime * 8;
        } else
        {
            SpawnEnemy();
            enemySpawnCount = 1f;
        }
    }

    public void SpawnEnemy()
    {
        GameObject enemy = Instantiate(Enemy, new Vector3(10f, 0.5f, Random.Range(-1,2)),  Quaternion.identity);
        while(targets[numberofEnemies] != null)
        {
            numberofEnemies++;
        }
        targets[numberofEnemies] = enemy;
        numberofEnemies = 0;
    } */
}
