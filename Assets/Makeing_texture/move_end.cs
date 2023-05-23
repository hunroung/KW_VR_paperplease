using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_end : MonoBehaviour
{
    public Transform stopPosition;
    //Vector3 destination = new Vector3((float)-6, (float)0.81, (float)-1.3);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, stopPosition.position, (float)0.01);
    }
}
