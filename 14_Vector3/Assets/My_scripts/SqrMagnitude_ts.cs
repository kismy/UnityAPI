using UnityEngine;
using System.Collections;

public class SqrMagnitude_ts : MonoBehaviour {
	void Start () {
        Vector3 v1 = new Vector3(3.0f,4.0f,5.0f);
        Vector3 v2 = new Vector3(1.0f, 2.0f, 8.0f);
        Debug.Log("����v1�ĳ��ȣ�"+v1.magnitude);
        Debug.Log("����v2�ĳ��ȣ�"+v2.magnitude);
        float f1 = v1.sqrMagnitude;
        float f2 = v2.sqrMagnitude;
        Debug.Log("v1ģ����ƽ��ֵ��" + f1 + "  v2ģ����ƽ��ֵ��" + f2);
        if(f1 == f2){
            Debug.Log("����v1��v2��ģ��һ����");
        }
        else if (f1 > f2)
        {
            Debug.Log("����v1��ģ���Ƚϴ�");
        }else{
            Debug.Log("����v2��ģ���Ƚϴ�");
        }
	}
}
