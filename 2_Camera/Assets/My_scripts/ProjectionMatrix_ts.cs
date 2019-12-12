using UnityEngine;
using System.Collections;

public class ProjectionMatrix_ts : MonoBehaviour
{
    public Transform sp, cb;
    public Matrix4x4 originalProjection;
    float q=0.1f;//�ζ����
    float p=1.5f;//�ζ�Ƶ��
    int which_change = -1;
    void Start()
    {
        //��¼ԭʼͶӰ����
        originalProjection = camera.projectionMatrix;
    }
    void Update()
    {
        sp.RotateAround(cb.position, cb.up, 45.0f * Time.deltaTime);
        Matrix4x4 pr = originalProjection;
        switch (which_change)
        {
            case -1:
                break;
            case 0:
                //�������X��ζ�
                pr.m11 += Mathf.Sin(Time.time * p) * q;
                break;
            case 1:
                //�������Y��ζ�
                pr.m01 += Mathf.Sin(Time.time * p) * q;
                break;
            case 2:
                //�������Z��ζ�
                pr.m10 += Mathf.Sin(Time.time * p) * q;
                break;
            case 3:
                //������������ƶ�
                pr.m02 += Mathf.Sin(Time.time * p) * q;
                break;
            case 4:
                //������ӿڷ����˶�
                pr.m00 += Mathf.Sin(Time.time * p) * q;
                break;
        }
        //����Camera�ı任����
        camera.projectionMatrix = pr;
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "�������X��ζ�"))
        {
            camera.ResetProjectionMatrix();
            which_change = 0;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "�������Y��ζ�"))
        {
            camera.ResetProjectionMatrix();
            which_change = 1;
        }
        if (GUI.Button(new Rect(10.0f, 110.0f, 200.0f, 45.0f), "�������Z��ζ�"))
        {
            camera.ResetProjectionMatrix();
            which_change = 2;
        }
        if (GUI.Button(new Rect(10.0f, 160.0f, 200.0f, 45.0f), "������������ƶ�"))
        {
            camera.ResetProjectionMatrix();
            which_change = 3;
        }
        if (GUI.Button(new Rect(10.0f, 210.0f, 200.0f, 45.0f), "�ӿڷ����˶�"))
        {
            camera.ResetProjectionMatrix();
            which_change = 4;
        }
    }
}