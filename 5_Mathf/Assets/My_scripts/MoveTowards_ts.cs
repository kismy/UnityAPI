using UnityEngine;
using System.Collections;
public class MoveTowards_ts : MonoBehaviour
{
    void Start()
    {
        float a, b, d;
        a = 10.0f;
        b = -10.0f;
        d = 5.0f;
        //a>b,��a-d>b������ֵΪa-d
        Debug.Log("Test01:" + Mathf.MoveTowards(a, b, d));
        d = 50.0f;
        //a>b,��a-d<b������ֵΪb
        Debug.Log("Test02:" + Mathf.MoveTowards(a, b, d));

        a = 10.0f;
        b = 50.0f;
        d = 5.0f;
        //a<b,��a+d<b������ֵΪa+d
        Debug.Log("Test03:" + Mathf.MoveTowards(a, b, d));
        d = 50.0f;
        //a<b,��a+d>b������ֵΪb
        Debug.Log("Test04��" + Mathf.MoveTowards(a, b, d));
    }
}
