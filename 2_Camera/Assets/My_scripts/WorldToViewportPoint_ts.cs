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
        //��¼��Ļ�Ŀ�Ⱥ͸߶�
        sw = Screen.width;
        sh = Screen.height;
    }
    void Update()
    {
        //����spʼ����cb��Y����ת
        sp.RotateAround(cb.position, cb.up, 30.0f * Time.deltaTime);
        //��¼spӳ�䵽��Ļ�ϵı���ֵ
        v3 = camera.WorldToViewportPoint(sp.position);
    }
    void OnGUI()
    {
        //�����������ڷ���WorldToViewportPoint�ķ���ֵ��y�����Ǵ���Ļ�·����Ϸ������ģ�
        //������Ҫ�ȼ���1.0f - v3.y��ֵ��Ȼ���ٺ�sh��ˡ�
        GUI.DrawTexture(new Rect(0.0f, sh * (1.0f - v3.y), sw * v3.x, sh), t2);
    }
}
