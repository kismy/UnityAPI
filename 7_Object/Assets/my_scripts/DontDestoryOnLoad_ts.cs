using UnityEngine;
using System.Collections;

public class DontDestoryOnLoad_ts : MonoBehaviour
{
    public GameObject g1, g2;
    public Renderer re1, re2;
    void Start()
    {
        //g1ָ��һ�����㸸�������,�ڵ�����Sceneʱg1������
        DontDestroyOnLoad(g1);
        //g2ָ��һ����������ڵ�����Sceneʱ�ᷢ��g2û�б�����
        DontDestroyOnLoad(g2);
        //re1ָ��һ�����㸸�����Renderer���,�ڵ�����Sceneʱre1������
        DontDestroyOnLoad(re1);
        //re2ָ��һ����������renderer������ڵ�����Sceneʱ�ᷢ��re2ָ��Ķ������û�б�����
        DontDestroyOnLoad(re2);
        Application.LoadLevel("FindObjectsOfType_unity");
    }
}
