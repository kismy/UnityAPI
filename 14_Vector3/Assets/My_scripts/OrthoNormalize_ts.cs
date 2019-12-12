using UnityEngine;
using System.Collections;

public class OrthoNormalize_ts : MonoBehaviour {
    public Transform one_T, two_T;
    Vector3 one_v, two_v;
    Vector3 one_l, two_l;

    void Start()
    {
        //��ʼ����ʼλ��
        one_v = one_T.position;
        two_v = two_T.position;
        //��¼��ʼ��λ��
        one_l = one_v;
        two_l = two_v;
    }

    void Update()
    {
        Vector3.OrthoNormalize(ref one_v,ref two_v);
        //����ԭʼ������OrthoNormalize����������
        Debug.DrawLine(Vector3.zero, one_l, Color.black);
        Debug.DrawLine(Vector3.zero, two_l, Color.white);
        Debug.DrawLine(Vector3.zero, one_v, Color.red);
        Debug.DrawLine(Vector3.zero, two_v, Color.yellow);
    }
}
