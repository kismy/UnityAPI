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
        //��¼��Ļ�߶�
        sg = Screen.height;
    }
    void Update()
    {
        //sp����cb��Y����ת
        sp.RotateAround(cb.position, cb.up, 30.0f * Time.deltaTime);
        //��ȡsp����Ļ�ϵ������
        v3 = camera.WorldToScreenPoint(sp.position);
    }
    void OnGUI()
    {
        //��������
        GUI.DrawTexture(new Rect(0.0f, sg - v3.y, v3.x, sg), t2);
    }
}
