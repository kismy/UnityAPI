using UnityEngine;
using System.Collections;

public class MultiplyVector_ts : MonoBehaviour
{
    public Transform tr;
    Matrix4x4 mv0 = Matrix4x4.identity;
    Matrix4x4 mv1 = Matrix4x4.identity;

    void Start()
    {
        //分别设置变换矩阵mv0和mv1的位置变换和角度变换都不为0
        mv0.SetTRS(Vector3.one * 10.0f, Quaternion.Euler(new Vector3(0.0f, 30.0f, 0.0f)), Vector3.one);
        mv1.SetTRS(Vector3.one * 10.0f, Quaternion.Euler(new Vector3(0.0f, 0.6f, 0.0f)), Vector3.one);
    }

    void Update()
    {
        //用tr来定位变换后的向量
        tr.position = mv1.MultiplyVector(tr.position);
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 120.0f, 45.0f), "方向旋转30度"))
        {
            Vector3 v = mv0.MultiplyVector(new Vector3(10.0f, 0.0f, 0.0f));
            //打印旋转后的向量，其方向发生了旋转
            Debug.Log("变换后向量："+v);
            //打印旋转后向量的长度，
            //尽管mv0的位置变换不为0，但变换后向量的长度应与变换前相同
            Debug.Log("变换后向量模长：" + v.magnitude);
        }
    }
}
