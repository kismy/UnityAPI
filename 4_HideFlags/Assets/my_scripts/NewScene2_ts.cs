using UnityEngine;
using System.Collections;

public class NewScene2_ts : MonoBehaviour
{
    GameObject cube, plane;
    void Start()
    {
        Debug.Log("����NewScene2��");
    }
    //�������˳�ʱ��DestroyImmediate()���ٱ�HideFlags.DontSave��ʶ�Ķ���,
    //����ʹ�����Ѿ��˳�����HideFlags.DontSave��ʶ�Ķ�����Ȼ��Hierarchy����У�
    //��ÿ����һ�γ���ͻ���������������ڴ�й©��
    void OnApplicationQuit()
    {
        cube = GameObject.Find("Cube0");
        plane = GameObject.Find("Plane");
        if (cube)
        {
            Debug.Log("Cube0 DestroyImmediate");
            DestroyImmediate(cube);
        }
        if (plane)
        {
            Debug.Log("Plane DestroyImmediate");
            DestroyImmediate(plane);
        }
    }
}
