using UnityEngine;
using System.Collections;

public class DataPath_ts : MonoBehaviour
{
    void Start()
    {
        //四种不同的path，都为只读
        //dataPath和streamingAssetsPath的路径位置一般是相对程序的安装目录位置
        //persistentDataPath和temporaryCachePath的路径位置一般是相对所在系统的固定位置
        Debug.Log("dataPath:" + Application.dataPath);
        Debug.Log("persistentDataPath:" + Application.persistentDataPath);
        Debug.Log("streamingAssetsPath:" + Application.streamingAssetsPath);
        Debug.Log("temporaryCachePath:" + Application.temporaryCachePath);
    }
}
