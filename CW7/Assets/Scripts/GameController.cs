using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform Spawn;
    public Transform spawnleft;
    public Transform spawnRight;




    public GameObject Enemy;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int randnum = Random.Range(1, 4);

        if (randnum == 1) 
        {
            Instantiate(Enemy, spawnleft); 
        } 

        else if (randnum == 2) 
        {
            Instantiate(Enemy, Spawn);
        } 


        else 
        {
            Instantiate(Enemy, spawnRight);
        
        }

    }
}
