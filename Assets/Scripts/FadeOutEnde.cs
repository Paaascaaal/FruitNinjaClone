using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutEnde : MonoBehaviour
{
    public Text minusLeben;

    

    
    // Start is called before the first frame update
    void Start()
    {
        minusLeben.transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(0f,10f));
        minusLeben.CrossFadeAlpha(0f, 3f, true);
        Destroy(gameObject, 5f);

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
