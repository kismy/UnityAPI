using UnityEngine;
using System.Collections;

public class Lerp_ts : MonoBehaviour
{
    void Start()
    {
        Vector2 v1 = new Vector2(4.0f, 12.0f);
        Vector2 v2 = new Vector2(9.0f, 20.0f);
        //e<0ʱ����ֵΪv1��ֵ
        Debug.Log("e<0ʱ����ֵΪv1��ֵ:" + Vector2.Lerp(v1, v2, -2.0f));
        //e>1ʱ����ֵΪv2��ֵ
        Debug.Log("e>1ʱ����ֵΪv2��ֵ:" + Vector2.Lerp(v1, v2, 2.0f));
        //e>0��e<1ʱ����ֵ�㷨�󷵻�ֵ
        Debug.Log("e>0��e<1ʱ����ֵ�㷨�󷵻�ֵ:" + Vector2.Lerp(v1, v2, 0.7f));
    }
}
