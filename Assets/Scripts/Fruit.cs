using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject slicedFruitPrefab;
    public float explosionRadius;
    public float minExplosionForce;
    public float maxExplosionForce;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void CreateSlicedFruit()
    {
        GameObject inst = Instantiate(slicedFruitPrefab, transform.position, transform.rotation);

        Rigidbody[] rbOnSliced = inst.transform.GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rb in rbOnSliced)
        {
            rb.transform.rotation = Random.rotation;
            rb.AddExplosionForce(Random.Range(minExplosionForce, maxExplosionForce), transform.position, explosionRadius);
        }

      

        Destroy(gameObject);
        Destroy(inst.gameObject, 5f);
    }



    private void OnTriggerEnter(Collider other)
    {
        Blade b = other.GetComponent<Blade>();

        

        if (!b)
        {
            return;
        } else if (b && Input.GetButton("Fire1"))
        {

            FindObjectOfType<GameManager>().IncreaseScore(3);
            FindObjectOfType<GameManager>().HighScore(0);
            CreateSlicedFruit();

            
        }
        
    }






}
