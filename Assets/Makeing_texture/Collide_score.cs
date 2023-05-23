using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static System.Int32;
public class Collide_score : MonoBehaviour
{
    int score_ = 0;
    private void OnTriggerEnter(Collider other)
    {
        GameObject pass= GameObject.Find("passport_test");
        if(GameObject.Find("P_C(Clone)").tag== pass.tag)
        {
            TMP_Text score = GameObject.Find("score").GetComponent<TMP_Text>();
            score_++;
            score.text= score_.ToString();
            Destroy(GameObject.Find("P_C(Clone)"));
            Destroy(GameObject.Find("passport"));
            GameObject respawn = GameObject.Find("start_point");
            P_C_moving a = respawn.GetComponent<P_C_moving>();
            a.i = 1;
        }
        else
        {
            TMP_Text score = GameObject.Find("score").GetComponent<TMP_Text>();
            score_--;
            score.text = score_.ToString();
            Destroy(GameObject.Find("P_C(Clone)"));
            Destroy(GameObject.Find("passport"));
            GameObject respawn = GameObject.Find("start_point");
            P_C_moving a = respawn.GetComponent<P_C_moving>();
            a.i = 1;
        }
        
    }
}
    