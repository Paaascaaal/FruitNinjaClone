using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerUdemy : MonoBehaviour
{
    public GameObject[] fruitToSpawnPrefab;
    public Transform[] spawnPlaces;
    public GameObject bombPrefab;

    public float minWait = 0.3f;
    public float maxWait = 1.0f;

    public float maxHochschiessKraft = 10.0f;
    public float minHochschiessKraft = 5.0f;
    

    public float torque = 10f;

    public float xTorque;
    public float yTorque;
    public float zTorque;

    public float minRotation = 0f;
    public float maxRotation = 10f;

    public int randomFruit;
    public int randomFruityFruit;

    

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SpawnFruits());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnFruits()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            
            yield return new WaitForSeconds(Random.Range(minWait, maxWait));

            Transform t = spawnPlaces[Random.Range(0, spawnPlaces.Length)];


            GameObject go = null;

            randomFruit = Random.Range(0, 100);
            

            if(randomFruit <= 10)
            {
                go = fruitToSpawnPrefab[3];
            }else
            {
                randomFruityFruit = Random.Range(0,fruitToSpawnPrefab.Length);
                go = fruitToSpawnPrefab[randomFruityFruit];
            }

            
            
     


            GameObject fruit = Instantiate(go, t.transform.position, go.transform.rotation);


            fruit.GetComponent<Rigidbody>().AddForce(t.transform.up * Random.Range(minHochschiessKraft, maxHochschiessKraft));

            xTorque = Random.Range(0, 30f);
            yTorque = Random.Range(0, 30f);
            zTorque = Random.Range(0, 30f);

            fruit.GetComponent<Rigidbody>().AddTorque(xTorque, yTorque, zTorque); 
            
            

            

            Destroy(fruit, 5f);
        }
    }

   
}
