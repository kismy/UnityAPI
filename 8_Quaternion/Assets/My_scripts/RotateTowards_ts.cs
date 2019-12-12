using UnityEngine;
using System.Collections;

public class RotateTowards_ts : MonoBehaviour {
    public Transform A, B, C;
    float speed = 10.0f;

    void Update()
    {
        C.rotation = Quaternion.RotateTowards(A.rotation, B.rotation, Time.time * speed-40.0f);
        Debug.Log("C与A的欧拉角的差值：" + (C.eulerAngles-A.eulerAngles) + " maxDegreesDelta:" + (Time.time * speed - 40.0f));
    }
}
