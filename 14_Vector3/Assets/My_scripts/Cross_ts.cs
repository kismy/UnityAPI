using UnityEngine;
using System.Collections;

public class Cross_ts : MonoBehaviour {
    public Transform A, B;
    Vector3 A_v, B_v;
    Vector3 C_v = Vector3.zero;

    void Update()
    {
        A_v = A.position;
        B_v = B.position;
        C_v = Vector3.Cross(A_v,B_v);

        Debug.DrawLine(Vector3.zero, A_v , Color.green);
        Debug.DrawLine(Vector3.zero, B_v, Color.yellow);
        Debug.DrawLine(Vector3.zero, C_v, Color.red);
    }
}