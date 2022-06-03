using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public GameController GameController;
    private double newPos;
    public bool Arrived;
    public bool Active = false;
    private Vector3 diff;
    
    void Start()
    {
        Arrived = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("StartBall") && !Arrived)
        {
            Vector3 mousePos = Input.mousePosition;
            newPos =(mousePos.x/Screen.width * 4.5)-2.5;
            if (newPos < -2.5)
            {
                newPos = -2.5;
            }
            if (newPos > 2)
            {
                newPos = 2;
            }
            transform.position = new Vector3((float)(newPos), transform.position.y, transform.position.z);
        }
        else if(gameObject.CompareTag("Ball") && Active && !Arrived)
        {
            transform.position = new Vector3(GameController.StartBall.transform.position.x + diff.x, transform.position.y,GameController.StartBall.transform.position.z + diff.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Active.Equals(false) && (collision.gameObject.CompareTag("Ball") || collision.gameObject.CompareTag("StartBall")))
        {
            Active = true;
            Color BallColor = new Color(Random.value, Random.value, Random.value);
            diff = new Vector3(transform.position.x - GameController.StartBall.transform.position.x,0,transform.position.z - GameController.StartBall.transform.position.z) ;
            //Console.WriteLine("In collision " + diff);
            /*collision.gameObject.*/GetComponent<Rigidbody>().useGravity = true;
            //collision.gameObject.GetComponent<BallBehavior>().Active = true;
            collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color",BallColor);
            
            
        }
    }
}
