using UnityEngine;
using System.Collections;

public class EulerAngle_ts : MonoBehaviour
{
    public Transform A, B;
    Quaternion rotations=Quaternion.identity;
    Vector3 eulerAngle = Vector3.zero;
    float speed = 10.0f;

    void Update()
    {
        //第一种方式：将Quaternion赋值给transform的rotation
        rotations.eulerAngles = new Vector3(0.0f, speed * Time.time, 0.0f);
        A.rotation = rotations;
        //第二种方式：将三维向量代表的欧拉角直接赋值给transform的eulerAngles
        eulerAngle = new Vector3(0.0f, speed * Time.time, 0.0f);
        B.eulerAngles = eulerAngle;
    }
}
