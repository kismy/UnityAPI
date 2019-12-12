using UnityEngine;
using System.Collections;

public class Capture_Use_Sub_ts : MonoBehaviour
{
    //物体移动的目标位置
    public Vector3 toward;
    //物体移动时间
    float delays;
    void Start()
    {
        //获取一个随机值
        delays = Random.Range(2.0f, 4.0f);
    }

    void Update()
    {
        //通过更改物体位置来达到物体运动的效果
        transform.position = Vector3.MoveTowards(transform.position, toward, delays);
    }
}
