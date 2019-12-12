using UnityEngine;
using System.Collections;

public class SmoothDampAngle_ts : MonoBehaviour
{
    public Transform targets;
    float smoothTime = 0.3f;
    float distance = 5.0f;
    float yVelocity = 0.0f;
    void Update()
    {
        //����ƽ������Ƕ�ֵ
        float yAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targets.eulerAngles.y, ref yVelocity, smoothTime);
        Vector3 positions = targets.position;
        //����ʹ��transform.LookAt���˴�����targets��-z�᷽�����targetsΪdistance��
        //ŷ����Ϊ�������target��y����תyAngle������λ��
        positions += Quaternion.Euler(0, yAngle, 0) * new Vector3(0, 0, -distance);
        //����ƫ��2����λ
        transform.position = positions + new Vector3(0.0f, 2.0f, 0.0f);
        transform.LookAt(targets);
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "��targets��ת60��"))
        {
            //����targets��eulerAngles
            targets.eulerAngles += new Vector3(0.0f, 60.0f, 0.0f);
        }
    }
}
