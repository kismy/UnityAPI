using UnityEngine;
using System.Collections;

/**
 * 机枪子弹
 * */

public class Jq_bullet : MonoBehaviour
{
    public Transform tk_exp;//爆炸效果组件
    float this_time = 0.0f;
    void Start()
    {
        this_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //如果子弹4秒内未打到物体，则自动销毁，避免内存浪费
        if (Time.time - this_time > 4.0f)
        {
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {
        //子弹以每秒100的速度向局部forward方向运动
        transform.rigidbody.velocity = transform.TransformDirection(Vector3.forward * 100);
    }

    void OnTriggerEnter(Collider otherObject)
    {
        //爆炸效果及销毁对象
        Instantiate(tk_exp, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
