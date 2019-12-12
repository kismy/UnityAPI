using UnityEngine;
using System.Collections;

public class Angle_ts : MonoBehaviour
{
    void Start()
    {
        Debug.Log("1:" + Vector3.Angle(Vector3.right, -Vector3.right));
        Debug.Log("2:" + Vector3.Angle(Vector3.right, -(Vector3.right + Vector3.up)));
        Debug.Log("3:" + Vector3.Angle(Vector3.right, Vector3.zero));
    }
}
