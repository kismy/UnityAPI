using UnityEngine;
using System.Collections;

public class ToAngleAxis_ts : MonoBehaviour
{
    public Transform A, B;
    float angle;
    Vector3 axis = Vector3.zero;

    void Update()
    {
        //ʹ��ToAngleAxis��ȡA��Rotation����ת��ͽǶ�
        A.rotation.ToAngleAxis(out angle, out axis);
        //ʹ��AngleAxis����B��rotation��ʹ��B��rotation״̬�ĺ�A��ͬ
        //�����ڳ�������ʱ�޸�A��rotation�鿴B��״̬
        B.rotation = Quaternion.AngleAxis(angle, axis);
    }
}
