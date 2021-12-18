using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("ScoreStuff")]
    public static int score;

    public Text scoreTextUdemy;
    public Text highScore;

    public int highscore;

    [Header("LebenVerlieren")]
    public GameObject endPanel;
    
    public SpriteRenderer zero;
    public SpriteRenderer one;
    public SpriteRenderer two;
    public SpriteRenderer three;
    
    public static int leben = 3;

    public GameObject endEndPanel;

    [Header("Sonstiges")]
    public GameObject[] spawner;
    public GameObject[] fruits;

    public GameObject scorePanel;
    //public GameObject ScoreCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        leben = 3;
        three.enabled = true;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
        
        
    }

    private void LateUpdate()
    {
        HighScore(highscore);
    }

    public void LoadNewScene()
    {
        score = 0;
        SceneManager.LoadScene("Level1");
        
    }

    public int IncreaseScore(int num)
    {
        score += num;
        scoreTextUdemy.text = "Score:\n" + score.ToString();

        if (PlayerPrefs.GetInt("Highscore") < score)
        {
            PlayerPrefs.SetInt("Highscore", score);
        }

        return score;
    }

   

    public int HighScore(int highscore)
    {
        highscore = PlayerPrefs.GetInt("Highscore");
        highScore.text = "Highscore:\n" + highscore.ToString();
        
        return highscore;
    }

    public void OnBombHit()
    {
        fruits = GameObject.FindGameObjectsWithTag("Fruit");

        foreach (GameObject fruit in fruits)
        {
            Destroy(fruit);
        }
        
        leben -= 1;
        
        zero.enabled = false;
        one.enabled = false;
        two.enabled = false;
        three.enabled = false;
        if (leben == 2)
        {
            two.enabled = true;
            
            Instantiate(endPanel);

            StartCoroutine(waiter(0.3f));
        }
        else if (leben == 1)
        {
            one.enabled = true;
            
            Instantiate(endPanel);

            StartCoroutine(waiter(0.3f));
        }
        else if (leben == 0)
        {
            zero.enabled = true;
            
            Instantiate(endPanel);

            StartCoroutine(waiter(0.3f));
        }else if (leben < 0)
        {
            spawner = GameObject.FindGameObjectsWithTag("Spawner");
            
            

            foreach (GameObject spawner in spawner)
            {
                Destroy(spawner);
            }

            Camera.main.GetComponent<AudioSource>().enabled = false;

            Instantiate(endEndPanel);

            StartCoroutine(waiter2(0.3f));

            
        }

        
    }



    private IEnumerator waiter(float waitTime)
    {
        
        yield return new WaitForSeconds(waitTime);
        Instantiate (endPanel);
        yield return new WaitForSeconds(waitTime);
        Instantiate(endPanel);
        yield return new WaitForSeconds(waitTime);
        Instantiate(endPanel);
    }

    private IEnumerator waiter2(float waitTime)
    {
        
        yield return new WaitForSeconds(waitTime);
        Instantiate(endEndPanel);
        yield return new WaitForSeconds(waitTime);
        Instantiate(endEndPanel);
        yield return new WaitForSeconds(waitTime);
        Instantiate(endEndPanel);
    }
}
