using UnityEngine;
using System.Collections;

public class LoadedLevel_ts : MonoBehaviour
{
    void Start()
    {
        //���ص�ǰ����������ֵ
        Debug.Log("loadedLevel:" + Application.loadedLevel);
        //���ص�ǰ����������
        Debug.Log("loadedLevelName:" + Application.loadedLevelName);
        //�Ƿ��г������ڱ�����
        Debug.Log("isLoadingLevel:" + Application.isLoadingLevel);
        //������Ϸ�пɱ����صĳ�������
        Debug.Log("levelCount:" + Application.levelCount);
        //���ص�ǰ��Ϸ������ƽ̨
        Debug.Log("platform:" + Application.platform);
        //��ǰ��Ϸ�Ƿ���������
        Debug.Log("isPlaying:" + Application.isPlaying);
        //��ǰ��Ϸ�Ƿ���Unity�༭ģʽ
        Debug.Log("isEditor:" + Application.isEditor);
    }
}
