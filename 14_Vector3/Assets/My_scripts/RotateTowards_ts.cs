using UnityEngine;
using System.Collections;

public class RotateTowards_ts : MonoBehaviour
{
    public Transform from_T, to_T;
    Vector3 from_v, to_v;
    Vector3 rotates = Vector3.zero;
    float speed = 0.2f;
    float l;

    void Start()
    {
        //��ʼ����ʼλ��
        from_v = from_T.position;
        to_v = to_T.position;
        //lȡֵΪ0ʱ��rotates����from_v��ģ���˶���to_v����
       // l = 0.0f;
        //lȡֵΪ(to_v - from_v).sqrMagnitudeʱ��rotates����to_v��ģ���˶���to_v����
        l = (to_v - from_v).sqrMagnitude;
    }

    void Update()
    {
        //��1/speedʱ����rotates��from_v�ƶ���to_v
        rotates = Vector3.RotateTowards(from_v, to_v, Time.time*speed,l);
        //���ƴ�ԭ�㵽slerps�ĺ��ߣ�������100���Ա�۲�
        //����ʱֻ����scene��ͼ�в鿴
        Debug.DrawLine(Vector3.zero, rotates, Color.red, 100.0f);
    }
}
