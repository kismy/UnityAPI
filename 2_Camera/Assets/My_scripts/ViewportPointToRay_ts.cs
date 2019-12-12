using UnityEngine;
using System.Collections;

public class ViewportPointToRay_ts : MonoBehaviour
{
    Ray ray;//射线
    RaycastHit hit;
    Vector3 v3 = new Vector3(0.5f, 0.5f, 0.0f);
    Vector3 hitpoint = Vector3.zero;
    void Update()
    {
        //射线沿着屏幕X轴从左向右循环扫描
        v3.x = v3.x >= 1.0f ? 0.0f : v3.x + 0.002f;
        //生成射线
        ray = camera.ViewportPointToRay(v3);
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            //绘制线，在Scene视图中可见
            Debug.DrawLine(ray.origin, hit.point, Color.green);
            //输出射线探测到的物体的名称
            Debug.Log("射线探测到的物体名称：" + hit.transform.name);
        }
    }
}
