using UnityEngine;
using System.Collections;

public class QxQ_ts : MonoBehaviour {
    public Transform A, B;

	void Start () {
        //����A��ŷ����
        //���Ÿ��ĸ��������鿴B�Ĳ�ͬ��ת״̬
        A.eulerAngles = new Vector3(1.0f,1.5f,2.0f);
	}
	
	void Update () {
        B.rotation *= A.rotation;
        //���B��ŷ���ǣ�ע��۲�B��ŷ���Ǳ仯
        Debug.Log(B.eulerAngles);
	}
}
