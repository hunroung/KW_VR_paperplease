using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide_stamp_no : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)

    {
        Debug.Log(other.name + "NO ¿€µø");
        if (other.name == "passport_test")
        {
            other.tag = "NO";
        }
    }
}
