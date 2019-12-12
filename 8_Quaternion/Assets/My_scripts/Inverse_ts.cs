using UnityEngine;
using System.Collections;

public class Inverse_ts : MonoBehaviour
{
    public Transform A, B;
    void Start()
    {
        Quaternion q1 = Quaternion.identity;
        Quaternion q2 = Quaternion.identity;
        q1.eulerAngles = new Vector3(10.0f, 20.0f, 30.0f);
        q2 = Quaternion.Inverse(q1);

        A.rotation = q1;
        B.rotation = q2;

        Debug.Log("q1的欧拉角：" + q1.eulerAngles + " q1的rotation：" + q1);
        Debug.Log("q2的欧拉角：" + q2.eulerAngles + " q2的rotation：" + q2);
    }
}
