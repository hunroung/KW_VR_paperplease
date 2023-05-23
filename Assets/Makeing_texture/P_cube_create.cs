using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class P_cube_create : MonoBehaviour
{
    public string name;
    public string type;
    public int age = 0;
    public string num;
    

    public string[] cube_name = new string[] { "��׸�", "�̳׸�", "�ڳ׸�", "�ֳ׸�", "�ƹ����׸�", "�ѳ׸�", "�ǳ׸�", "�۳׸�" };
    public string[] sphere_name = new string[] { "�赿�۵���", "�豸", "�ڱ�", "�ڵ���", "�����", "�ڹ�", "�蹮", "�̹�", "�̵���", "�̱�", "�ֱ�" };
    public string[] type_name = new string[] { "������ü", "��" };
    public string[] num_name = new string[] { "C-", "S-" };

    //public GameObject text_name, text_type, text_country, text_num;
    public GameObject childObject;
    private TextMesh targetTextMesh;

    // Start is called before the first frame update
    void Start()
    {
        
        System.Random rand = new System.Random();
        
        int r = rand.Next(0, 7);
        //Debug.Log(r);
        name = cube_name[r];
        //Debug.Log(name);
        type = type_name[0];
        
        age = rand.Next(0, 200);

        num = num_name[0] + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString();

        //text_name = transform.Find("Text_name");
        // textMesh = text_name.GetComponent<TextMesh>();
        //textMesh.name = name;

        targetTextMesh = childObject.transform.Find("Text_name").GetComponent<TextMesh>();
        targetTextMesh.text = name;
        targetTextMesh = childObject.transform.Find("Text_type").GetComponent<TextMesh>();
        targetTextMesh.text = type;
        targetTextMesh = childObject.transform.Find("Text_age").GetComponent<TextMesh>();
        targetTextMesh.text = age.ToString();
        targetTextMesh = childObject.transform.Find("Text_num").GetComponent<TextMesh>();
        targetTextMesh.text=num;
        this.gameObject.tag = "YES";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
