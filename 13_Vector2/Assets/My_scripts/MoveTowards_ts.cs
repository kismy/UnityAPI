using UnityEngine;
using System.Collections;

public class MoveTowards_ts : MonoBehaviour
{
    void Start()
    {
        Vector2 A = new Vector2(10.0f, 20.0f);
        Vector2 B = new Vector2(30.0f, 40.0f);
        //��K=1ʱ����B��ֵ
        float sp = (B - A).magnitude;
        Vector2 C = Vector2.MoveTowards(A, B, sp);
        Debug.Log("��K=1ʱ����B��ֵ:" + C.ToString());
        //��K>1ʱ����B��ֵ
        sp += 10.0f;
        C = Vector2.MoveTowards(A, B, sp);
        Debug.Log("��K>1ʱ����B��ֵ:" + C.ToString());
        //��K=0ʱ����A��ֵ
        sp = 0.0f;
        C = Vector2.MoveTowards(A, B, sp);
        Debug.Log("��K=0ʱ����A��ֵ:" + C.ToString());
        //��K<0ʱ���㷨����
        sp = -10.0f;
        C = Vector2.MoveTowards(A, B, sp);
        Debug.Log("��K<0ʱ���㷨����:" + C.ToString());
        //��K>0��K<1ʱ���㷨����
        sp = (B - A).magnitude * 0.7f;
        C = Vector2.MoveTowards(A, B, sp);
        Debug.Log("��K>0��K<1ʱ���㷨����:" + C.ToString());
    }
}
