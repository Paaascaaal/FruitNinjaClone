using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
        gameObject.GetComponent<Text>().CrossFadeColor(Color.green, 2.5f, true,false);

        StartCoroutine(waiter(2.5f));

        Destroy(gameObject,6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator waiter(float waitTime)
    {
        yield return new WaitForSeconds(1.1f);
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 18.81f;

        yield return new WaitForSeconds(waitTime - 1.1f);

        
        gameObject.GetComponent<Text>().CrossFadeAlpha(0f, 1.0f, true);
    }
}
