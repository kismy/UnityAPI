using UnityEngine;
using System.Collections;

public class SmoothStep_ts : MonoBehaviour {
    float min = 10.0f;
    float max = 110.0f;
    float f1, f2=0.0f;
	
	void FixedUpdate () {
        //f1ΪSmoothStep��ֵ����ֵ
        f1 = Mathf.SmoothStep(min,max,Time.time);
        //����������֡��ֵ�ı仯
        f2 = f1 - f2;
        Debug.Log("f1:"+f1);
        Debug.Log("f2:" + f2);
        f2 = f1;
	}
}
