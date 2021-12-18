using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().pitch = Random.Range(0.4f, 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
