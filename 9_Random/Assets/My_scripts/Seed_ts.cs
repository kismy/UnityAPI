using UnityEngine;
using System.Collections;

public class Seed_ts : MonoBehaviour
{
    void Start()
    {
        //���������������
        //��ͬ�����Ӳ�����ͬ�����������
        //������ͬ�����ӣ��ڳ���ÿ������ʱ����������ͬ��
        Random.seed = 1;
    }
    void Update()
    {
        Debug.Log(Random.value);
    }
}
