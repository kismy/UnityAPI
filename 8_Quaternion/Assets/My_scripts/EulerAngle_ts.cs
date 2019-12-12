using UnityEngine;
using System.Collections;

public class EulerAngle_ts : MonoBehaviour
{
    public Transform A, B;
    Quaternion rotations=Quaternion.identity;
    Vector3 eulerAngle = Vector3.zero;
    float speed = 10.0f;

    void Update()
    {
        //��һ�ַ�ʽ����Quaternion��ֵ��transform��rotation
        rotations.eulerAngles = new Vector3(0.0f, speed * Time.time, 0.0f);
        A.rotation = rotations;
        //�ڶ��ַ�ʽ������ά���������ŷ����ֱ�Ӹ�ֵ��transform��eulerAngles
        eulerAngle = new Vector3(0.0f, speed * Time.time, 0.0f);
        B.eulerAngles = eulerAngle;
    }
}
