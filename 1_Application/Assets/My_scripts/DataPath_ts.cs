using UnityEngine;
using System.Collections;

public class DataPath_ts : MonoBehaviour
{
    void Start()
    {
        //���ֲ�ͬ��path����Ϊֻ��
        //dataPath��streamingAssetsPath��·��λ��һ������Գ���İ�װĿ¼λ��
        //persistentDataPath��temporaryCachePath��·��λ��һ�����������ϵͳ�Ĺ̶�λ��
        Debug.Log("dataPath:" + Application.dataPath);
        Debug.Log("persistentDataPath:" + Application.persistentDataPath);
        Debug.Log("streamingAssetsPath:" + Application.streamingAssetsPath);
        Debug.Log("temporaryCachePath:" + Application.temporaryCachePath);
    }
}
