using UnityEngine;
using System.Collections;

public class Dot_ts : MonoBehaviour {
    public Transform A, B;
    Quaternion q1=Quaternion.identity;
    Quaternion q2=Quaternion.identity;
    float f;

	void Start () {
        A.eulerAngles = new Vector3(0.0f,40.0f,0.0f);
        //B比A绕Y轴多转360度
        B.eulerAngles = new Vector3(0.0f, 360.0f+40.0f, 0.0f);
        q1 = A.rotation;
        q2 = B.rotation;
        f = Quaternion.Dot(q1,q2);
        Debug.Log("q1的rotation:"+q1);
        Debug.Log("q2的rotation:" + q2);
        Debug.Log("q1的欧拉角:" + q1.eulerAngles);
        Debug.Log("q2的欧拉角:" + q2.eulerAngles);
        Debug.Log("Dot(q1,q2):"+f);
	}
}
