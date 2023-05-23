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

    public string[] cube_name = new string[] { "김네모", "이네모", "박네모", "최네모", "아무개네모", "한네모", "권네모", "송네모" };
    public string r_cube_name(int a) { return cube_name[a]; }
    public int cube_name_length() { return 7; }
    public string[] sphere_name = new string[] { "김동글동글", "김구", "박구", "박동글", "박쟁반", "박문", "김문", "이문", "이동글", "이구", "최구" };
    public string r_sphere_name(int a) { return sphere_name[a]; }
    public int sphere_name_length() { return 10; }
    public string[] type_name = new string[] { "정육면체", "구" };
    public string r_type_name(int a) { return type_name[a]; }
    public string[] num_name = new string[] { "C-", "S-" };
}

