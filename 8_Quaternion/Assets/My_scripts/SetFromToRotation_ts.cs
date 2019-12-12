using UnityEngine;
using System.Collections;

public class SetFromToRotation_ts : MonoBehaviour {
    public Transform A, B, C;
    Quaternion q1 = Quaternion.identity;
	
	void Update () {
        //不可直接使用C.rotation.SetFromToRotation(A.position,B.position);
        q1.SetFromToRotation(A.position,B.position);
        C.rotation = q1;

        Debug.DrawLine(Vector3.zero,A.position,Color.red);
        Debug.DrawLine(Vector3.zero, B.position, Color.green);
        Debug.DrawLine(C.position, C.position+new Vector3(0.0f,1.0f,0.0f), Color.black);
        Debug.DrawLine(C.position, C.TransformPoint(Vector3.up*1.5f), Color.yellow);
	}
}
