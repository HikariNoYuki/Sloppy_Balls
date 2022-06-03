using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject StartBall;
    private bool Started;
    public Text display;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Started = true;
            StartBall.GetComponent<Rigidbody>().useGravity = true;
        }

        if (Started)
        {
            display.text = "" + Score;
        }
        else
        {
            display.text = "Click !";
        }
            
    }
    
}
