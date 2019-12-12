using UnityEngine;
using System.Collections;

public class Angle_ts : MonoBehaviour {
    void Start()
    {
        Quaternion q1 = Quaternion.identity;
        Quaternion q2 = Quaternion.identity;
        q1.eulerAngles = new Vector3(10.0f, 20.0f, 30.0f);
        float f1 = Quaternion.Angle(q1,q2);
        float f2 = 0.0f;
        Vector3 v1 = Vector3.zero;
        q1.ToAngleAxis(out f2, out v1);

        Debug.Log("f1:" + f1);
        Debug.Log("f2:" + f2);
        Debug.Log("q1的欧拉角：" + q1.eulerAngles + " q1的rotation：" + q1);
        Debug.Log("q2的欧拉角：" + q2.eulerAngles + " q2的rotation：" + q2);
    }
}
