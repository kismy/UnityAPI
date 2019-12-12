using UnityEngine;
using System.Collections;

public class OrthoAndPerspective_ts : MonoBehaviour
{
    Matrix4x4 Perspective = Matrix4x4.identity;//͸��ͶӰ����
    Matrix4x4 ortho = Matrix4x4.identity;//����ͶӰ����
    //�������������ڼ�¼�����ӿڵ����ҡ��¡��ϵ�ֵ
    float l, r, b, t;
    void Start()
    {
        //����͸��ͶӰ����
        Perspective = Matrix4x4.Perspective(65.0f, 1.5f, 0.1f, 500.0f);
        t = 10.0f;
        b = -t;
        //Ϊ��ֹ��ͼ������Ҫ�� Camera.main.aspect���
        l = b * Camera.main.aspect;
        r = t * Camera.main.aspect;
        //��������ͶӰ����
        ortho = Matrix4x4.Ortho(l, r, b, t, 0.1f, 100.0f);
    }

    void OnGUI()
    {
        //ʹ��Ĭ������ͶӰ
        if (GUI.Button(new Rect(10.0f, 8.0f, 150.0f, 20.0f), "Reset Ortho"))
        {
            Camera.main.orthographic = true;
            Camera.main.ResetProjectionMatrix();
            Camera.main.orthographicSize = 5.1f;
        }
        //ʹ���Զ�������ͶӰ
        if (GUI.Button(new Rect(10.0f, 38.0f, 150.0f, 20.0f), "use Ortho"))
        {
            ortho = Matrix4x4.Ortho(l, r, b, t, 0.1f, 100.0f);
            Camera.main.orthographic = true;
            Camera.main.ResetProjectionMatrix();
            Camera.main.projectionMatrix = ortho;
            Camera.main.orthographicSize = 5.1f;
        }
        //ʹ���Զ���͸��ͶӰ
        if (GUI.Button(new Rect(10.0f, 68.0f, 150.0f, 20.0f), "use Perspective"))
        {
            Camera.main.orthographic = false;
            Camera.main.projectionMatrix = Perspective;
        }
        //�ָ�ϵͳĬ��͸��ͶӰ
        if (GUI.Button(new Rect(10.0f, 98.0f, 150.0f, 20.0f), "Reset  Perspective"))
        {
            Camera.main.orthographic = false;
            Camera.main.ResetProjectionMatrix();
        }
    }
}
