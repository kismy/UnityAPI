using UnityEngine;
using System.Collections;

public class SmoothDampAngle_ts : MonoBehaviour
{
    public Transform targets;
    float smoothTime = 0.3f;
    float distance = 5.0f;
    float yVelocity = 0.0f;
    void Update()
    {
        //返回平滑阻尼角度值
        float yAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targets.eulerAngles.y, ref yVelocity, smoothTime);
        Vector3 positions = targets.position;
        //由于使用transform.LookAt，此处计算targets的-z轴方向距离targets为distance，
        //欧拉角为摄像机绕target的y轴旋转yAngle的坐标位置
        positions += Quaternion.Euler(0, yAngle, 0) * new Vector3(0, 0, -distance);
        //向上偏移2个单位
        transform.position = positions + new Vector3(0.0f, 2.0f, 0.0f);
        transform.LookAt(targets);
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "将targets旋转60度"))
        {
            //更改targets的eulerAngles
            targets.eulerAngles += new Vector3(0.0f, 60.0f, 0.0f);
        }
    }
}
