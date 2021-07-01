using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Assertions;

public class BirdMvntsScript : MonoBehaviour
{
    public GameObject beekBird;
    public const int SPEED = 30;
    public Vector3 userDirection = Vector3.right;
    public Vector3 userDirectionDown = Vector3.right;
    public String result = null;
    public AutoResetEvent are = new AutoResetEvent(false);
    public string myName;
    public bool isDone = false;
    // Start is called before the first frame update
    void Start()
    {
        myName = "Angelique";
        beekBird = GameObject.Find("BeekRedOpen1");
        Debug.Log("Welcome to the Birds Game!" + myName + beekBird );
        userDirection.x = 16;

        // Instantiate(beekBird, new Vector3(0, 0, 0), Quaternion.identity);
        //transform.Translate(transform.right * Speed * Time.smoothDeltaTime);
        firstMoveBird();
        Thread.Sleep(3000);
        if (isDone)  myEventsWithHandler("waited no result....");

    }

    // Update is called once per frame
    void Update()
    { }
    public void firstMoveBird()
    {
        beekBird.transform.Translate(userDirection * SPEED * Time.deltaTime);
        isDone = true;
    }
    public void myEventsWithHandler(String msg){ 
        result = msg; 
        are.Set();
        if (!are.WaitOne(3000)) { Debug.Log(msg); }
        else userDirectionDown.y = -6;
             beekBird.transform.Translate(userDirectionDown * SPEED * Time.deltaTime);
    }
       
        
    
}
