using UnityEngine;
using System.Collections;
public class LayerCullDistances_ts : MonoBehaviour
{
    public Transform cb1;
    void Start()
    {
        //�����СΪ32��һά���飬�����洢���в���޳�����
        float[] distances = new float[32];
        //���õ�9����޳�����
        distances[8] = Vector3.Distance(transform.position, cb1.position);
        //�����鸳���������layerCullDistances
        camera.layerCullDistances = distances;
    }
    void Update()
    {
        //�����Զ������
        transform.Translate(transform.right * Time.deltaTime);
    }
}