using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private Rigidbody rb;
    public float mousePosXPlus = 10f;
    public float mousePosYPlus = 10f;

    public float minVelo = 0.1f;

    private Vector3 curMousePos;
    private Vector3 lastMousePos;

    private Collider col;

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        
        

            
    }

    void Start()
    {
        SetBladeToMouse(false);
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetButton("Fire1"))
        {
            SetBladeToMouse(true);
        }else if (!Input.GetButton("Fire1")) { SetBladeToMouse(false); }

        
    }

    private void FixedUpdate()
    {
        
        col.enabled = IsMouseMoving();
    }

    private void SetBladeToMouse(bool anzeigen)
    {
        gameObject.GetComponent<TrailRenderer>().enabled = anzeigen;
        var mousePos = Input.mousePosition;
        mousePos.z = 10;
        mousePos.x = mousePos.x + mousePosXPlus;
        mousePos.y = mousePos.y - mousePosYPlus;
        rb.position = Camera.main.ScreenToWorldPoint(mousePos);
        
    }

    private bool IsMouseMoving()
    {
        curMousePos = Input.mousePosition;
        float traveled = (lastMousePos - curMousePos).magnitude;
        lastMousePos = curMousePos;
        

        if (traveled >= minVelo)
        {
            return true;
        }
        else if (traveled < minVelo)
        { 
            return false; 
        }else { return false;}
        
    }


}
