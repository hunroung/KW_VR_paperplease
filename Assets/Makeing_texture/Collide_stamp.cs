using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide_stamp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)

    {
        Debug.Log(other.name + "yes ¿€µø");
        if (other.name == "passport_test")
        {
            other.tag = "YES";
        }
    }
}
