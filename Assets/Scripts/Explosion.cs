using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public float radius = 5.0F;
    public float power = 10.0F;

    public GameObject[] startFruits;
    public GameObject[] endFruits;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject fruit in startFruits)
        {
            fruit.GetComponent<Rigidbody>().useGravity = false;
            Destroy(fruit, 5f);
        }
        foreach(GameObject fruit in endFruits)
        {
            Destroy(fruit, 5f);
        }
        Physics.IgnoreLayerCollision(8, 8);
        StartCoroutine(waiter(1.1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waiter(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        foreach (GameObject fruit in startFruits)
        {
            fruit.GetComponent<Rigidbody>().useGravity = true;
        }

        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
        }
    }
}
