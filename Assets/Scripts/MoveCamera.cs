using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public int screenWidth;
    public int screenHeight;

    public Vector3 cameraPosition;
    public Vector3 mousePos;

    

    // Start is called before the first frame update
    void Start()
    {
        screenHeight = Screen.height;
        screenWidth = Screen.width;
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 1.0f;
        //Debug.Log(Camera.main.ScreenToWorldPoint(mousePos));

        
        if ((Camera.main.ScreenToWorldPoint(mousePos).x - 0.5f) <= -1.0f)
        {
            Debug.Log("Yes");
           
        }
    }
    
}
