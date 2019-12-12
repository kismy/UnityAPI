using UnityEngine;
using System.Collections;

public class Slerp_ts : MonoBehaviour
{
    public Transform A, B, C, D;
    float speed = 0.2f;
    //�ֱ���ʾ����Slerp��Lerp��ʹ��
    void Update()
    {
        C.rotation = Quaternion.Slerp(A.rotation, B.rotation, Time.time * speed);
        D.rotation = Quaternion.Lerp(A.rotation, B.rotation, Time.time * speed);
    }
}
