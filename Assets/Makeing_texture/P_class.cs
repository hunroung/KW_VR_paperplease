using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_class : MonoBehaviour
{
    public string name;
    public string type;
    public int age = 0;
    public string num;
    public void n_name(string t) { name = t; }
    public void n_type(string t) { type = t; }
    public void n_num(string t) { num = t; }
    public string r_name() { return name; }
    public string r_type() { return type; }
    public string r_num() { return num; }
    public string r_age() { return age.ToString(); }

    public string[] cube_name = new string[] { "��׸�", "�̳׸�", "�ڳ׸�", "�ֳ׸�", "�ƹ����׸�", "�ѳ׸�", "�ǳ׸�", "�۳׸�" };
    public string r_cube_name(int a) { return cube_name[a]; }
    public int cube_name_length() { return 7; }
    public string[] sphere_name = new string[] { "�赿�۵���", "�豸", "�ڱ�", "�ڵ���", "�����", "�ڹ�", "�蹮", "�̹�", "�̵���", "�̱�", "�ֱ�" };
    public string r_sphere_name(int a) { return sphere_name[a]; }
    public int sphere_name_length() { return 10; }
    public string[] type_name = new string[] { "������ü", "��" };
    public string r_type_name(int a) { return type_name[a]; }
    public string[] num_name = new string[] { "C-", "S-" };
}

