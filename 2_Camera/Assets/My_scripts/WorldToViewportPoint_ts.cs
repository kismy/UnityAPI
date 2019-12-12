using UnityEngine;
using System.Collections;

public class WorldToViewportPoint_ts : MonoBehaviour
{
    public Transform cb, sp;
    public Texture2D t2;
    Vector3 v3 = Vector3.zero;
    float sw, sh;
    void Start()
    {
        //记录屏幕的宽度和高度
        sw = Screen.width;
        sh = Screen.height;
    }
    void Update()
    {
        //物体sp始终绕cb的Y轴旋转
        sp.RotateAround(cb.position, cb.up, 30.0f * Time.deltaTime);
        //记录sp映射到屏幕上的比例值
        v3 = camera.WorldToViewportPoint(sp.position);
    }
    void OnGUI()
    {
        //绘制纹理，由于方法WorldToViewportPoint的返回值的y分量是从屏幕下方向上方递增的，
        //所以需要先计算1.0f - v3.y的值，然后再和sh相乘。
        GUI.DrawTexture(new Rect(0.0f, sh * (1.0f - v3.y), sw * v3.x, sh), t2);
    }
}
