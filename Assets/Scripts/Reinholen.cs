using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reinholen : MonoBehaviour
{

    public GameManager gameManager;
    public GameObject scorePanel;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(gameManager);
        Instantiate(scorePanel);

        DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
