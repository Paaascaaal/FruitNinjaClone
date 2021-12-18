using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutEndeEnde : MonoBehaviour
{
    public Text endText;
    public Button restart;
    
    // Start is called before the first frame update
    void Start()
    {
        endText.transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(0f,10f));
        endText.CrossFadeAlpha(0f, 3f, true);
        Destroy(endText, 5f);

        restart.onClick.AddListener(OnButtonRestart);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonRestart()
    {
        FindObjectOfType<GameManager>().IncreaseScore(-(GameManager.score));
        FindObjectOfType<GameManager>().LoadNewScene();
    }



}
