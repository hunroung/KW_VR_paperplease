using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide_passport : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)

    {
        Debug.Log(other.name + "Collide_passport ¿€µø");
        if(other.tag=="YES" || other.tag=="NO")
        {
            GameObject p = GameObject.Find("P_C(Clone)");
            GameObject t = GameObject.Find("end_point");
            p.AddComponent<move_end>().stopPosition = t.transform;
            Destroy(this);
        }
    }
}
    