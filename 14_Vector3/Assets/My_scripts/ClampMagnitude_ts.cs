using UnityEngine;
using System.Collections;

public class ClampMagnitude_ts : MonoBehaviour {
	void Start () {
        Vector3 ts = new Vector3(1.0f,2.0f,3.0f);
        Debug.Log("ts�ĵ�λ����Ϊ��"+ts.normalized+" tsģ��Ϊ��"+ts.magnitude);

        Debug.Log("��fֵ����tsģ��ʱ��");
        float f = ts.magnitude + 1.0f;
        Vector3 ov = Vector3.ClampMagnitude(ts,f);
        Debug.Log("ov����:" + ov.ToString()+"�䵥λ����Ϊ��"+ov.normalized + " ov��ģ��Ϊ:" + ov.magnitude);

        Debug.Log("��fֵС��tsģ��ʱ��");
        f = ts.magnitude - 1.0f;
        ov = Vector3.ClampMagnitude(ts,f);
        Debug.Log("ov����:" + ov.ToString() + "�䵥λ����Ϊ��" + ov.normalized + " ov��ģ��Ϊ:" + ov.magnitude);
	}
}
