using UnityEngine;
using System.Collections;

public class LoadedLevel_ts : MonoBehaviour
{
    void Start()
    {
        //返回当前场景的索引值
        Debug.Log("loadedLevel:" + Application.loadedLevel);
        //返回当前场景的名字
        Debug.Log("loadedLevelName:" + Application.loadedLevelName);
        //是否有场景正在被加载
        Debug.Log("isLoadingLevel:" + Application.isLoadingLevel);
        //返回游戏中可被加载的场景数量
        Debug.Log("levelCount:" + Application.levelCount);
        //返回当前游戏的运行平台
        Debug.Log("platform:" + Application.platform);
        //当前游戏是否正在运行
        Debug.Log("isPlaying:" + Application.isPlaying);
        //当前游戏是否处于Unity编辑模式
        Debug.Log("isEditor:" + Application.isEditor);
    }
}
