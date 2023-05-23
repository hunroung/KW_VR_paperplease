using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class P_cube : MonoBehaviour
{
    public string name;
    public string type;
    public int age = 0;
    public string num;

    public string[] cube_name = new string[] { "��׸�", "�̳׸�", "�ڳ׸�", "�ֳ׸�", "�ƹ����׸�", "�ѳ׸�", "�ǳ׸�", "�۳׸�" };
    public string[] sphere_name = new string[] { "�赿�۵���", "�豸", "�ڱ�", "�ڵ���", "�����", "�ڹ�", "�蹮", "�̹�", "�̵���", "�̱�", "�ֱ�" };
    public string[] type_name = new string[] { "������ü", "��" };
    public string[] num_name = new string[] { "C-", "S-" };

    // Start is called before the first frame update
    void Start()
    {

        System.Random rand = new System.Random();

        int r = rand.Next(0, 7);
        //Debug.Log(r);
        name = cube_name[r];
        //Debug.Log(name);
        type = type_name[r];

        age = rand.Next(0, 200);

        num = type_name[0] + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

}
