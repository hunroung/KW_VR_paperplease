using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    private void OnTriggerExit(Collider other)

    {
        Debug.Log(other.name + "���� ��!");
        if(other.tag=="spawn")
        {
            other.tag = "passport";
        }
        else if (other.tag =="passport")
        {
            Debug.Log(other.tag + "  Collide �۵���");
            GameObject t = GameObject.Find("arm_right");
            GameObject a = GameObject.Find("P_C(Clone)");
            Destroy(a.GetComponent<move>());
            t.AddComponent<Collide_passport>();
            Destroy(this);
        }

    }
   
}
