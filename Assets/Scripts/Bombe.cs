using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Blade b = other.GetComponent<Blade>();

        if (!b) { return; }
        else if (b && Input.GetButton("Fire1"))
        {
            FindObjectOfType<GameManager>().OnBombHit();

            Destroy(gameObject);


        }
    }
}
