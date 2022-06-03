using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBehavior : MonoBehaviour
{

    public GameController GameControl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        BallBehavior script = collision.gameObject.GetComponent<BallBehavior>();
        if (script.Arrived.Equals(false) && (collision.gameObject.CompareTag("Ball") || collision.gameObject.CompareTag("StartBall")))
        {
            GameControl.Score++;
            script.Arrived = true;

        }
    }
}
