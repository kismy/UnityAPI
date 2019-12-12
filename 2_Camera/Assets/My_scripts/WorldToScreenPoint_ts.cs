using UnityEngine;
using System.Collections;

public class WorldToScreenPoint_ts : MonoBehaviour
{
    public Transform cb, sp;
    public Texture2D t2;
    Vector3 v3 = Vector3.zero;
    float sg;
    void Start()
    {
        //记录屏幕高度
        sg = Screen.height;
    }
    void Update()
    {
        //sp绕着cb的Y轴旋转
        sp.RotateAround(cb.position, cb.up, 30.0f * Time.deltaTime);
        //获取sp在屏幕上的坐标点
        v3 = camera.WorldToScreenPoint(sp.position);
    }
    void OnGUI()
    {
        //绘制纹理
        GUI.DrawTexture(new Rect(0.0f, sg - v3.y, v3.x, sg), t2);
    }
}
