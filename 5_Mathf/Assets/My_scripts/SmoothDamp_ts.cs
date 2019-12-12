using UnityEngine;
using System.Collections;

public class SmoothDamp_ts : MonoBehaviour
{
    float targets = 110.0f;//Ŀ��ֵ
    float cv1 = 0.0f, cv2 = 0.0f;
    float maxSpeeds = 50.0f;//ÿ֡���ֵ
    float f1 = 10.0f, f2 = 10.0f;//��ʼֵ
    void FixedUpdate()
    {
        //maxSpeedȡĬ��ֵ
        f1 = Mathf.SmoothDamp(f1, targets, ref cv1, 0.5f);
        Debug.Log("f1:" + f1);
        Debug.Log("cv1:" + cv1);
        //maxSpeedȡ����ֵ50.0f
        f2 = Mathf.SmoothDamp(f2, targets, ref cv2, 0.5f, maxSpeeds);
        Debug.Log("f2:" + f2);
        Debug.Log("cv2:" + cv2);
    }
}
