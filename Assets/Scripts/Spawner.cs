using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Früchte spawnen, denen eine Velocity nach oben geben, Velocity random, Zeit random, Frucht an sich random, Ort random

public class Spawner : MonoBehaviour
{
    #region Public-Variables
    public GameObject orange;
    public GameObject melone;
    public GameObject banane;
    public GameObject bombe;

    public float startDelay;
    public float repeatTime;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFruit", startDelay, repeatTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnFruit()
    {
        int spawnVariable = Random.Range(0, 4);

        if (spawnVariable == 0)
        {
            Instantiate(orange, transform.position, orange.transform.rotation);
        } else if (spawnVariable == 1)
        {
            Instantiate (melone, transform.position, melone.transform.rotation);
        }
        else if (spawnVariable == 2)
        {
            Instantiate(banane, transform.position, banane.transform.rotation);
        }
        else if (spawnVariable == 3)
        {
            Instantiate(bombe, transform.position, bombe.transform.rotation);
        }
    }

}
