using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{
    public Transform targetObject;
    private Vector3 initialOffset;
    private Vector3 objectPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        initialOffset = new Vector3(0, transform.position.y - targetObject.position.y,transform.position.z - targetObject.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        objectPosition = new Vector3(0, targetObject.position.y + initialOffset.y, targetObject.position.z + initialOffset.z);
        transform.position = new Vector3(transform.position.x, objectPosition.y, objectPosition.z);
    }
}
