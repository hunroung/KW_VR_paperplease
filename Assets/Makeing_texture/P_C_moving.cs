using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_C_moving : MonoBehaviour
{
    public GameObject P_C;
    public GameObject P_S;
    public Transform spawnPosition;
    public int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (i == 1)
        {
            GameObject instance = Instantiate(P_C, spawnPosition.position, spawnPosition.rotation);
            GameObject t = GameObject.Find("stop_point");
            move a = instance.GetComponent<move>();
            a.stopPosition = t.transform;
            i = 0;
        }
    }
}
